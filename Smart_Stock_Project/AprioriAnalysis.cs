//AprioriAnalysis.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Smart_Stock_Project
{
    public partial class AprioriAnalysis : UserControl
    {
        SqlConnection connect;
        private DateTime lastUpdated = DateTime.MinValue;
        private List<AprioriRule> currentRules = new List<AprioriRule>();
        private List<TransactionData> currentTransactions = new List<TransactionData>();

        public AprioriAnalysis()
        {
            InitializeComponent();
            if (!IsInDesignMode())
            {
                string connStr = ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"]?.ConnectionString;
                if (!string.IsNullOrEmpty(connStr))
                {
                    connect = new SqlConnection(connStr);
                    InitializeDatabase(); // Create analysis history table
                    InitializeLastUpdatedLabel();
                    SetupFilterOptions();

                    // Load last analysis asynchronously without blocking constructor
                    _ = LoadLastAnalysisAsync();
                }
            }
        }

        private async Task LoadLastAnalysisAsync()
        {
            try
            {
                await LoadLastAnalysis();
            }
            catch (Exception ex)
            {
                // Handle any errors that occur during async loading
                Console.WriteLine($"Error loading last analysis: {ex.Message}");
            }
        }

        private bool IsInDesignMode()
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime) ||
                   (Process.GetCurrentProcess().ProcessName == "devenv");
        }

        private void InitializeDatabase()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                string createTableQuery = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='apriori_analysis_history' AND xtype='U')
                    CREATE TABLE apriori_analysis_history (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        analysis_date DATETIME,
                        total_transactions INT,
                        total_rules INT,
                        high_confidence_rules INT,
                        medium_confidence_rules INT,
                        analysis_results NTEXT,
                        top5_results NTEXT
                    )";

                using (SqlCommand cmd = new SqlCommand(createTableQuery, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Silent fail for table creation
                MessageBox.Show($"Database Initialization Error: {ex}", "SmartStock Analysis Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void InitializeLastUpdatedLabel()
        {
            lblLastUpdated.Text = "Analysis Status: Not Run Yet";
            lblLastUpdated.ForeColor = Color.Gray;
        }

        private void SetupFilterOptions()
        {
            // Setup date range filter
            dateTimePickerFrom.Value = DateTime.Now.AddDays(-30);
            dateTimePickerTo.Value = DateTime.Now;

            // Setup confidence filter
            comboBoxConfidenceFilter.Items.Clear();
            comboBoxConfidenceFilter.Items.AddRange(new string[] {
                "All Recommendations",
                "High Confidence (80%+)",
                "Medium Confidence (60-80%)",
                "Low Confidence (Below 60%)"
            });
            comboBoxConfidenceFilter.SelectedIndex = 0;

            // NEW: Setup category filter (dynamically load from database)
            comboBoxCategoryFilter.Items.Clear();
            comboBoxCategoryFilter.Items.Add("All Items"); // Always add "All Items" option first

            try
            {
                if (connect.State != ConnectionState.Open)
                    connect.Open();

                // Query to get distinct categories from the products table
                string query = "SELECT DISTINCT category FROM products WHERE category IS NOT NULL ORDER BY category";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            comboBoxCategoryFilter.Items.Add(reader["category"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log the error or display a message, but don't stop the application
                Console.WriteLine($"Error loading categories for filter: {ex}");

            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
            comboBoxCategoryFilter.SelectedIndex = 0; // Select "All Items" by default
        }

        // Enhanced Apriori Algorithm Classes
        public class AprioriRule
        {
            public List<string> FromItems { get; set; }
            public List<string> ToItems { get; set; }
            public double Support { get; set; }
            public double Confidence { get; set; }
            public string BusinessRecommendation { get; set; }
            public string ActionPlan { get; set; }
            public decimal PotentialRevenue { get; set; }
            public string Category { get; set; }
        }

        public class TransactionData
        {
            public int CustomerId { get; set; }
            public DateTime OrderDate { get; set; }
            public List<string> Items { get; set; }
            public double TransactionTotal { get; set; }
            public string TimeOfDay { get; set; }
            public string DayOfWeek { get; set; }
        }

        private async void btnRunAnalysis_Click(object sender, EventArgs e)
        {
            try
            {
                // Show loading state
                btnRunAnalysis.Enabled = false;
                btnRunAnalysis.Text = "📊 Analyzing Sales...";

                // Clear previous results
                listViewRecommendations.Items.Clear();
                richTextBoxBusinessInsights.Clear();

                // Show progress
                progressBarAnalysis.Visible = true;
                progressBarAnalysis.Value = 0;
                lblAnalysisStatus.Text = "Gathering transaction data...";
                lblAnalysisStatus.Visible = true;

                // Get transaction data with filters
                progressBarAnalysis.Value = 20;
                currentTransactions = await GetFilteredTransactionDataAsync();

                lblAnalysisStatus.Text = "Finding product patterns...";
                progressBarAnalysis.Value = 50;

                // Run enhanced Apriori algorithm
                currentRules = RunEnhancedAprioriAlgorithm(currentTransactions, 0.2, 0.5); // Lowered thresholds for more insights //0.2 is the minsupp and 0.5 is minConfi

                lblAnalysisStatus.Text = "Generating business recommendations...";
                progressBarAnalysis.Value = 80;

                // Display results
                DisplayBusinessRecommendations(currentRules);
                DisplayBusinessInsights(currentRules, currentTransactions.Count);

                progressBarAnalysis.Value = 100;
                lblAnalysisStatus.Text = "Analysis complete!";

                // Update timestamp and save analysis
                lastUpdated = DateTime.Now;
                lblLastUpdated.Text = $"Last Analysis: {lastUpdated:MMM dd, yyyy - hh:mm tt}";
                lblLastUpdated.ForeColor = Color.FromArgb(59, 130, 246);

                // Update statistics
                UpdateBusinessStatistics(currentRules);

                // Save analysis to database
                await SaveAnalysisToDatabase();

                await Task.Delay(1000);
                progressBarAnalysis.Visible = false;
                lblAnalysisStatus.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Analysis Error: {ex.Message}\n\nPlease check your database connection and try again.",
                    "SmartStock Analysis Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnRunAnalysis.Enabled = true;
                btnRunAnalysis.Text = "🔄 Run New Analysis";
                progressBarAnalysis.Visible = false;
                lblAnalysisStatus.Visible = false;
            }
        }

        private async Task<List<TransactionData>> GetFilteredTransactionDataAsync()
        {
            var transactions = new List<TransactionData>();

            string query = @"
                SELECT 
                    customer_id,
                    order_date,
                    STRING_AGG(prod_name, ',') as items,
                    SUM(total_price) as transaction_total
                FROM orders 
                WHERE order_date BETWEEN @FromDate AND @ToDate
                GROUP BY customer_id, order_date
                HAVING COUNT(*) >= 2  -- Only transactions with multiple items
                ORDER BY order_date DESC";

            try
            {
                if (connect.State != ConnectionState.Open)
                    await connect.OpenAsync();

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@FromDate", dateTimePickerFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@ToDate", dateTimePickerTo.Value.Date.AddDays(1));

                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            var orderDate = Convert.ToDateTime(reader["order_date"]);
                            var transaction = new TransactionData
                            {
                                CustomerId = Convert.ToInt32(reader["customer_id"]),
                                OrderDate = orderDate,
                                Items = reader["items"].ToString().Split(',').Select(s => s.Trim()).ToList(),
                                TransactionTotal = Convert.ToDouble(reader["transaction_total"]),
                                TimeOfDay = GetTimeCategory(orderDate),
                                DayOfWeek = orderDate.DayOfWeek.ToString()
                            };
                            transactions.Add(transaction);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database error: {ex.Message}");
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }

            return transactions;
        }

        private string GetTimeCategory(DateTime orderDate)
        {
            var hour = orderDate.Hour;
            if (hour >= 6 && hour < 11) return "Morning Rush";
            if (hour >= 11 && hour < 14) return "Lunch Peak";
            if (hour >= 14 && hour < 17) return "Afternoon";
            if (hour >= 17 && hour < 21) return "Dinner Rush";
            return "Late Night";
        }

        private List<AprioriRule> RunEnhancedAprioriAlgorithm(List<TransactionData> transactions, double minSupport, double minConfidence)
        {
            var rules = new List<AprioriRule>();

            if (transactions.Count == 0) return rules;

            // Get all unique items
            var allItems = transactions.SelectMany(t => t.Items).Distinct().ToList();

            // Calculate support for individual items
            var itemSupport = new Dictionary<string, double>();
            var itemRevenue = new Dictionary<string, decimal>();

            foreach (var item in allItems)
            {
                var supportCount = transactions.Count(t => t.Items.Contains(item));
                var support = (double)supportCount / transactions.Count;
                if (support >= minSupport)
                {
                    itemSupport[item] = support;
                    // Calculate average revenue per item in transactions containing this item
                    var itemTransactions = transactions.Where(t => t.Items.Contains(item));
                    itemRevenue[item] = (decimal)itemTransactions.Average(t => t.TransactionTotal / t.Items.Count);
                }
            }

            var frequentItems = itemSupport.Keys.ToList();

            // Generate 2-itemsets and business rules
            for (int i = 0; i < frequentItems.Count; i++)
            {
                for (int j = i + 1; j < frequentItems.Count; j++)
                {
                    var itemset = new List<string> { frequentItems[i], frequentItems[j] };
                    var supportCount = transactions.Count(t => itemset.All(item => t.Items.Contains(item)));
                    var support = (double)supportCount / transactions.Count;

                    if (support >= minSupport)
                    {
                        // Generate business rules A -> B
                        var confidence1 = support / itemSupport[frequentItems[i]];
                        var confidence2 = support / itemSupport[frequentItems[j]];

                        if (confidence1 >= minConfidence)
                        {
                            rules.Add(new AprioriRule
                            {
                                FromItems = new List<string> { frequentItems[i] },
                                ToItems = new List<string> { frequentItems[j] },
                                Support = support,
                                Confidence = confidence1,
                                BusinessRecommendation = GenerateBusinessRecommendation(frequentItems[i], frequentItems[j], confidence1, support),  
                                ActionPlan = GenerateActionPlan(frequentItems[i], frequentItems[j], confidence1),
                                PotentialRevenue = CalculatePotentialRevenue(frequentItems[j], supportCount, itemRevenue.ContainsKey(frequentItems[j]) ? itemRevenue[frequentItems[j]] : 0),
                                Category = DetermineItemCategory(frequentItems[i], frequentItems[j])
                            });
                        }

                        if (confidence2 >= minConfidence)
                        {
                            rules.Add(new AprioriRule
                            {
                                FromItems = new List<string> { frequentItems[j] },
                                ToItems = new List<string> { frequentItems[i] },
                                Support = support,
                                Confidence = confidence2,
                                BusinessRecommendation = GenerateBusinessRecommendation(frequentItems[j], frequentItems[i], confidence2, support),
                                ActionPlan = GenerateActionPlan(frequentItems[j], frequentItems[i], confidence2),
                                PotentialRevenue = CalculatePotentialRevenue(frequentItems[i], supportCount, itemRevenue.ContainsKey(frequentItems[i]) ? itemRevenue[frequentItems[i]] : 0),
                                Category = DetermineItemCategory(frequentItems[j], frequentItems[i])
                            });
                        }
                    }
                }
            }

            return rules.OrderByDescending(r => r.Confidence).ThenByDescending(r => r.Support).ToList();
        }

        private string GenerateBusinessRecommendation(string fromItem, string toItem, double confidence, double support)
        {
            var confidencePercent = confidence * 100;
            var supportPercent = support * 100;

            return $"When customers order {fromItem}, {confidencePercent:F0}% also buy {toItem}. " +
                   $"This combo appears in {supportPercent:F0}% of all orders. Consider creating a bundle deal!";
        }

        private string GenerateActionPlan(string fromItem, string toItem, double confidence)
        {
            if (confidence >= 0.8)
                return $"🔥 HIGH PRIORITY: Create '{fromItem} + {toItem}' combo meal. Train staff to suggest {toItem} when customers order {fromItem}.";
            else if (confidence >= 0.6)
                return $"💡 MEDIUM PRIORITY: Display {toItem} near {fromItem}. Add cross-selling prompt in POS system.";
            else
                return $"📝 LOW PRIORITY: Monitor this pattern. Consider seasonal promotions combining these items.";
        }

        private decimal CalculatePotentialRevenue(string item, int frequency, decimal avgPrice)
        {
            // Simple calculation - could be enhanced with actual product prices
            return frequency * avgPrice * 0.3m; // Assuming 30% additional revenue from cross-selling
        }

        private string DetermineItemCategory(string item1, string item2)
        {
            // Simple categorization - enhance based on your actual product categories
            var beverageKeywords = new[] { "coffee", "refresher", "drink", "juice", "water" };
            var foodKeywords = new[] { "popper", "mojo", "burger", "fries", "chicken" };

            if (beverageKeywords.Any(k => item1.ToLower().Contains(k) || item2.ToLower().Contains(k)))
                return "Food + Beverage";
            if (foodKeywords.Any(k => item1.ToLower().Contains(k) && item2.ToLower().Contains(k)))
                return "Food Combo";

            return "Mixed Items";
        }

        private void DisplayBusinessRecommendations(List<AprioriRule> rules)
        {
            var filteredRules = ApplyFilters(rules);
            listViewRecommendations.Items.Clear();

            for (int i = 0; i < Math.Min(filteredRules.Count, 10); i++) // Show top 10
            {
                var rule = filteredRules[i];
                var item = new ListViewItem($"#{i + 1}");
                item.SubItems.Add(string.Join(" + ", rule.FromItems));
                item.SubItems.Add(string.Join(" + ", rule.ToItems));
                item.SubItems.Add($"{rule.Confidence:P0}");
                item.SubItems.Add($"₱{rule.PotentialRevenue:N0}");
                item.SubItems.Add(rule.ActionPlan);

                // Enhanced color coding
                if (rule.Confidence >= 0.8)
                {
                    item.BackColor = Color.FromArgb(212, 255, 212); // Light green
                    item.ForeColor = Color.FromArgb(0, 100, 0);
                }
                else if (rule.Confidence >= 0.6)
                {
                    item.BackColor = Color.FromArgb(255, 248, 220); // Light yellow
                    item.ForeColor = Color.FromArgb(184, 134, 11);
                }
                else
                {
                    item.BackColor = Color.FromArgb(254, 226, 226); // Light red
                    item.ForeColor = Color.FromArgb(153, 27, 27);
                }

                listViewRecommendations.Items.Add(item);
            }
        }

        private List<AprioriRule> ApplyFilters(List<AprioriRule> rules)
        {
            var filtered = rules.AsEnumerable();

            // Apply confidence filter
            switch (comboBoxConfidenceFilter.SelectedIndex)
            {
                case 1: // High confidence
                    filtered = filtered.Where(r => r.Confidence >= 0.8);
                    break;
                case 2: // Medium confidence  
                    filtered = filtered.Where(r => r.Confidence >= 0.6 && r.Confidence < 0.8);
                    break;
                case 3: // Low confidence
                    filtered = filtered.Where(r => r.Confidence < 0.6);
                    break;
            }

            // Apply category filter
            if (comboBoxCategoryFilter.SelectedIndex > 0)
            {
                var selectedCategory = comboBoxCategoryFilter.SelectedItem.ToString();
                // Implement category filtering based on your product categories
            }

            return filtered.ToList();
        }

        private void DisplayBusinessInsights(List<AprioriRule> rules, int totalTransactions)
        {
            var sb = new StringBuilder();

            sb.AppendLine("🏪 OLD YORKERS BUSINESS INSIGHTS REPORT");
            sb.AppendLine("═══════════════════════════════════════════════");
            sb.AppendLine();

            sb.AppendLine($"📊 ANALYSIS SUMMARY ({dateTimePickerFrom.Value:MMM dd} - {dateTimePickerTo.Value:MMM dd, yyyy})");
            sb.AppendLine($"• Customer Orders Analyzed: {totalTransactions:N0}");
            sb.AppendLine($"• Product Combinations Found: {rules.Count:N0}");
            sb.AppendLine($"• High-Confidence Opportunities: {rules.Count(r => r.Confidence >= 0.8):N0}");
            sb.AppendLine($"• Potential Additional Revenue: ₱{rules.Sum(r => r.PotentialRevenue):N0}");
            sb.AppendLine();

            if (rules.Count > 0)
            {
                sb.AppendLine("🎯 TOP BUSINESS OPPORTUNITIES:");
                sb.AppendLine();

                var topRules = rules.Take(5);
                int rank = 1;
                foreach (var rule in topRules)
                {
                    sb.AppendLine($"#{rank}. {string.Join(" + ", rule.FromItems)} → {string.Join(" + ", rule.ToItems)}");
                    sb.AppendLine($"    • Success Rate: {rule.Confidence:P0} of customers");
                    sb.AppendLine($"    • Revenue Opportunity: ₱{rule.PotentialRevenue:N0}/month");
                    sb.AppendLine($"    • Action: {rule.ActionPlan}");
                    sb.AppendLine();
                    rank++;
                }

                sb.AppendLine("💰 REVENUE ENHANCEMENT STRATEGIES:");
                sb.AppendLine();

                // Bundle recommendations
                var bundles = rules.Where(r => r.Confidence >= 0.7).Take(3);
                sb.AppendLine("🎁 Recommended Bundle Deals:");
                foreach (var bundle in bundles)
                {
                    sb.AppendLine($"• '{string.Join(" & ", bundle.FromItems.Concat(bundle.ToItems))}' Combo");
                    sb.AppendLine($"  Discount: 10-15% to encourage purchase");
                    sb.AppendLine($"  Expected uptake: {bundle.Confidence:P0} of current customers");
                }
                sb.AppendLine();

                // Cross-selling strategies
                sb.AppendLine("🤝 Staff Training for Cross-Selling:");
                var crossSell = rules.Where(r => r.Confidence >= 0.6).Take(3);
                foreach (var cs in crossSell)
                {
                    sb.AppendLine($"• When customer orders {string.Join(", ", cs.FromItems)}:");
                    sb.AppendLine($"  Ask: 'Would you like to add {string.Join(", ", cs.ToItems)}?'");
                    sb.AppendLine($"  Success rate should be around {cs.Confidence:P0}");
                }
                sb.AppendLine();

                // Inventory insights
                sb.AppendLine("📦 INVENTORY MANAGEMENT INSIGHTS:");
                sb.AppendLine();
                sb.AppendLine("🔄 Smart Restocking Recommendations:");
                var restockRules = rules.OrderByDescending(r => r.Support).Take(5);
                foreach (var restock in restockRules)
                {
                    sb.AppendLine($"• When restocking {string.Join(", ", restock.FromItems)}:");
                    sb.AppendLine($"  Also order {string.Join(", ", restock.ToItems)} (they sell together {restock.Support:P0} of the time)");
                }
            }
            else
            {
                sb.AppendLine("❌ INSUFFICIENT DATA FOR RECOMMENDATIONS");
                sb.AppendLine();
                sb.AppendLine("📋 To get better insights:");
                sb.AppendLine("• Ensure at least 100 customer orders in the selected period");
                sb.AppendLine("• Verify customers are buying multiple items per order");
                sb.AppendLine("• Try expanding the date range to 60-90 days");
                sb.AppendLine("• Check if product names are consistent in the database");
            }

            richTextBoxBusinessInsights.Text = sb.ToString();
        }

        private void UpdateBusinessStatistics(List<AprioriRule> rules)
        {
            lblTotalOpportunities.Text = $"{rules.Count}";
            lblHighValue.Text = $"{rules.Count(r => r.Confidence >= 0.8)}";
            lblPotentialRevenue.Text = $"₱{rules.Sum(r => r.PotentialRevenue):N0}";
        }

        private async Task SaveAnalysisToDatabase()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    await connect.OpenAsync();

                string insertQuery = @"
                    INSERT INTO apriori_analysis_history 
                    (analysis_date, total_transactions, total_rules, high_confidence_rules, medium_confidence_rules, analysis_results, top5_results)
                    VALUES (@date, @transactions, @rules, @high, @medium, @analysis, @top5)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@date", lastUpdated);
                    cmd.Parameters.AddWithValue("@transactions", currentTransactions.Count);
                    cmd.Parameters.AddWithValue("@rules", currentRules.Count);
                    cmd.Parameters.AddWithValue("@high", currentRules.Count(r => r.Confidence >= 0.8));
                    cmd.Parameters.AddWithValue("@medium", currentRules.Count(r => r.Confidence >= 0.6 && r.Confidence < 0.8));
                    cmd.Parameters.AddWithValue("@analysis", richTextBoxBusinessInsights.Text);
                    cmd.Parameters.AddWithValue("@top5", SerializeTop5Results());

                    await cmd.ExecuteNonQueryAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving analysis: {ex}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        // Change this method from void to async Task
        private async Task LoadLastAnalysis()
        {
            try
            {
                if (connect.State != ConnectionState.Open)
                    await connect.OpenAsync(); // Use OpenAsync instead of Open

                string query = @"
            SELECT TOP 1 * FROM apriori_analysis_history 
            ORDER BY analysis_date DESC";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync()) // Use ExecuteReaderAsync
                    {
                        if (await reader.ReadAsync()) // Use ReadAsync
                        {
                            lastUpdated = Convert.ToDateTime(reader["analysis_date"]);
                            lblLastUpdated.Text = $"Last Analysis: {lastUpdated:MMM dd, yyyy - hh:mm tt}";
                            lblLastUpdated.ForeColor = Color.FromArgb(59, 130, 246);

                            // Load statistics
                            lblTotalOpportunities.Text = $"{Convert.ToInt32(reader["total_rules"])}";
                            lblHighValue.Text = $"{Convert.ToInt32(reader["high_confidence_rules"])}";

                            // Load analysis text
                            richTextBoxBusinessInsights.Text = reader["analysis_results"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading last analysis: {ex.Message}", "Database Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private string SerializeTop5Results()
        {
            var sb = new StringBuilder();
            foreach (ListViewItem item in listViewRecommendations.Items)
            {
                sb.AppendLine($"{item.Text}|{item.SubItems[1].Text}|{item.SubItems[2].Text}|{item.SubItems[3].Text}|{item.SubItems[4].Text}");
            }
            return sb.ToString();
        }

        // Filter event handlers
        private void OnFilterChanged(object sender, EventArgs e)
        {
            if (currentRules.Count > 0)
            {
                DisplayBusinessRecommendations(currentRules);
            }
        }

        // Export functionality with enhanced business format
        private void btnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Text Report (*.txt)|*.txt";
                saveDialog.FileName = $"OldYorkers_BusinessInsights_{DateTime.Now:yyyyMMdd_HHmm}";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    if (saveDialog.FilterIndex == 1) // TXT 
                    {
                        System.IO.File.WriteAllText(saveDialog.FileName, richTextBoxBusinessInsights.Text);

                    }

                    MessageBox.Show("Business insights report exported successfully!", "Export Complete",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Export Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ExportToCSV(string fileName)
        {
            var csv = new StringBuilder();
            csv.AppendLine("Rank,From Item,To Item,Success Rate,Revenue Potential,Action Plan");

            foreach (ListViewItem item in listViewRecommendations.Items)
            {
                csv.AppendLine($"{item.Text},{item.SubItems[1].Text},{item.SubItems[2].Text},{item.SubItems[3].Text},{item.SubItems[4].Text},\"{item.SubItems[5].Text}\"");
            }

            System.IO.File.WriteAllText(fileName, csv.ToString());
        }

        private void groupBoxRecommendations_Enter(object sender, EventArgs e)
        {
            // Empty event handler
        }

        private void lblLastUpdated_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLastUpdated_Click(object sender, EventArgs e)
        {

        }

        private void panelStat2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}