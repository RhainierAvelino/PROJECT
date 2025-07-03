//SalesForecasting.cs
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Smart_Stock_Project
{
    public partial class SalesForecasting : UserControl // Changed from Form to UserControl
    {
        private SqlConnection connect;
        private Timer refreshTimer;

        public SalesForecasting()
        {
            InitializeComponent();
            // Removed IsInDesignMode() check as it's typically for Forms, and
            // UserControls usually handle their initialization directly.
            string connStr = ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"]?.ConnectionString;
            if (!string.IsNullOrEmpty(connStr))
            {
                connect = new SqlConnection(connStr);
                InitializeDatabase();
                InitializeTimer();
                LoadLastForecastAnalysis();
                UpdateLastAnalysisLabel();
            }
        }

        // Removed IsInDesignMode() method

        private void InitializeDatabase()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                // Create sales forecasting analysis table
                string createTable = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='sales_forecast_analysis' AND type='U')
                    CREATE TABLE sales_forecast_analysis (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        prod_id VARCHAR(MAX),
                        prod_name VARCHAR(MAX),
                        category VARCHAR(MAX),
                        current_stock INT,
                        avg_daily_sales FLOAT,
                        predicted_stockout_date DATE,
                        reorder_point INT,
                        recommended_order_qty INT,
                        priority_level VARCHAR(20),
                        forecast_accuracy FLOAT,
                        analysis_date DATETIME,
                        last_updated DATETIME DEFAULT GETDATE()
                    )";

                using (SqlCommand cmd = new SqlCommand(createTable, connect))
                {
                    cmd.ExecuteNonQuery();
                }

                // Create forecast history table
                string createHistoryTable = @"
                    IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='forecast_history' AND type='U')
                    CREATE TABLE forecast_history (
                        id INT IDENTITY(1,1) PRIMARY KEY,
                        analysis_date DATETIME,
                        total_products_analyzed INT,
                        critical_items_count INT,
                        reorder_recommendations INT,
                        insights_summary TEXT,
                        created_date DATETIME DEFAULT GETDATE()
                    )";

                using (SqlCommand cmd = new SqlCommand(createHistoryTable, connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // In a UserControl, you might want to log this or expose an event
                // instead of showing a MessageBox directly.
                // MessageBox.Show($"Database initialization error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Database initialization error: {ex.Message}");
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void InitializeTimer()
        {
            refreshTimer = new Timer();
            refreshTimer.Interval = 60000; // 1 minute
            refreshTimer.Tick += (s, e) => UpdateLastAnalysisLabel();
            refreshTimer.Start();
        }

        private void btnRunAnalysis_Click(object sender, EventArgs e)
        {
            // For a UserControl, you might consider custom event handling or a different UI approach
            // for confirmations, rather than directly using MessageBox.Show.
            if (MessageBox.Show("Running new analysis will update all forecasting data. Continue?",
                "Confirm Analysis", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RunSalesForecastAnalysis();
            }
        }

        private void RunSalesForecastAnalysis()
        {
            progressBar.Visible = true;
            progressBar.Style = ProgressBarStyle.Marquee;
            btnRunAnalysis.Enabled = false;
            lblStatus.Text = "🔄 Analyzing sales patterns...";
            lblStatus.ForeColor = Color.FromArgb(52, 152, 219);

            try
            {
                // Clear previous analysis
                ClearPreviousAnalysis();

                // Get products and their sales data
                var productsData = GetProductsSalesData();

                progressBar.Value = 30;
                lblStatus.Text = "📊 Calculating demand forecasts...";

                // Perform forecasting analysis
                var forecastResults = PerformForecastingAnalysis(productsData);

                progressBar.Value = 60;
                lblStatus.Text = "💾 Saving analysis results...";

                // Save results to database
                SaveForecastResults(forecastResults);

                progressBar.Value = 90;
                lblStatus.Text = "📈 Loading updated data...";

                // Load and display results
                LoadForecastResults();

                progressBar.Value = 100;
                lblStatus.Text = "✅ Analysis completed successfully!";
                lblStatus.ForeColor = Color.FromArgb(46, 204, 113);

                // Save to history
                SaveAnalysisToHistory(forecastResults.Count);

                UpdateLastAnalysisLabel();

                // Hide progress after 2 seconds
                Timer hideTimer = new Timer();
                hideTimer.Interval = 2000;
                hideTimer.Tick += (s, args) =>
                {
                    progressBar.Visible = false;
                    lblStatus.Text = "Ready for analysis";
                    lblStatus.ForeColor = Color.FromArgb(127, 140, 141);
                    hideTimer.Stop();
                };
                hideTimer.Start();
            }
            catch (Exception ex)
            {
                // In a UserControl, you might want to log this or expose an event
                // instead of showing a MessageBox directly.
                // MessageBox.Show($"Analysis error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Analysis error: {ex.Message}");
                lblStatus.Text = "❌ Analysis failed";
                lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
                progressBar.Visible = false;
            }
            finally
            {
                btnRunAnalysis.Enabled = true;
            }
        }

        private List<ProductSalesData> GetProductsSalesData()
        {
            var productsData = new List<ProductSalesData>();

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = @"
                    SELECT 
                        p.prod_id,
                        p.prod_name,
                        p.category,
                        p.stock as current_stock,
                        ISNULL(AVG(CAST(o.quantity as FLOAT)), 0) as avg_daily_sales,
                        ISNULL(SUM(o.quantity), 0) as total_sales_30_days,
                        COUNT(DISTINCT o.order_date) as active_sales_days
                    FROM products p
                    LEFT JOIN orders o ON p.prod_id = o.prod_id 
                        AND o.order_date >= DATEADD(day, -30, GETDATE())
                    WHERE p.status = 'Available'
                    GROUP BY p.prod_id, p.prod_name, p.category, p.stock";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productsData.Add(new ProductSalesData
                            {
                                ProdId = reader["prod_id"].ToString(),
                                ProdName = reader["prod_name"].ToString(),
                                Category = reader["category"].ToString(),
                                CurrentStock = Convert.ToInt32(reader["current_stock"]),
                                AvgDailySales = Convert.ToDouble(reader["avg_daily_sales"]),
                                TotalSales30Days = Convert.ToInt32(reader["total_sales_30_days"]),
                                ActiveSalesDays = Convert.ToInt32(reader["active_sales_days"])
                            });
                        }
                    }
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }

            return productsData;
        }

        private List<ForecastResult> PerformForecastingAnalysis(List<ProductSalesData> productsData)
        {
            var results = new List<ForecastResult>();

            foreach (var product in productsData)
            {
                var forecast = new ForecastResult
                {
                    ProdId = product.ProdId,
                    ProdName = product.ProdName,
                    Category = product.Category,
                    CurrentStock = product.CurrentStock,
                    AvgDailySales = product.AvgDailySales
                };

                // Calculate days until stockout
                double daysUntilStockout = product.AvgDailySales > 0
                    ? product.CurrentStock / product.AvgDailySales
                    : 999;

                forecast.PredictedStockoutDate = daysUntilStockout < 999
                    ? DateTime.Now.AddDays(daysUntilStockout)
                    : DateTime.Now.AddDays(365);

                // Determine priority level
                if (daysUntilStockout <= 3)
                    forecast.PriorityLevel = "CRITICAL";
                else if (daysUntilStockout <= 7)
                    forecast.PriorityLevel = "HIGH";
                else if (daysUntilStockout <= 14)
                    forecast.PriorityLevel = "MEDIUM";
                else
                    forecast.PriorityLevel = "LOW";

                // Calculate reorder recommendations
                forecast.ReorderPoint = (int)(product.AvgDailySales * 5); // 5-day safety stock
                forecast.RecommendedOrderQty = Math.Max(
                    (int)(product.AvgDailySales * 14), // 2 weeks supply
                    forecast.ReorderPoint * 2
                );

                // Calculate forecast accuracy (simplified)
                forecast.ForecastAccuracy = product.ActiveSalesDays > 0 ?
                    Math.Min(95, 60 + (product.ActiveSalesDays * 2)) : 50;

                results.Add(forecast);
            }

            return results.OrderBy(r => r.PredictedStockoutDate).ToList();
        }

        private void ClearPreviousAnalysis()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM sales_forecast_analysis", connect))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void SaveForecastResults(List<ForecastResult> results)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                foreach (var result in results)
                {
                    string insertQuery = @"
                        INSERT INTO sales_forecast_analysis 
                        (prod_id, prod_name, category, current_stock, avg_daily_sales, 
                         predicted_stockout_date, reorder_point, recommended_order_qty, 
                         priority_level, forecast_accuracy, analysis_date)
                        VALUES (@prodId, @prodName, @category, @currentStock, @avgDailySales,
                                @stockoutDate, @reorderPoint, @orderQty, @priority, @accuracy, @analysisDate)";

                    using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                    {
                        cmd.Parameters.AddWithValue("@prodId", result.ProdId);
                        cmd.Parameters.AddWithValue("@prodName", result.ProdName);
                        cmd.Parameters.AddWithValue("@category", result.Category);
                        cmd.Parameters.AddWithValue("@currentStock", result.CurrentStock);
                        cmd.Parameters.AddWithValue("@avgDailySales", result.AvgDailySales);
                        cmd.Parameters.AddWithValue("@stockoutDate", result.PredictedStockoutDate);
                        cmd.Parameters.AddWithValue("@reorderPoint", result.ReorderPoint);
                        cmd.Parameters.AddWithValue("@orderQty", result.RecommendedOrderQty);
                        cmd.Parameters.AddWithValue("@priority", result.PriorityLevel);
                        cmd.Parameters.AddWithValue("@accuracy", result.ForecastAccuracy);
                        cmd.Parameters.AddWithValue("@analysisDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void LoadForecastResults()
        {
            LoadLastForecastAnalysis();
            LoadCriticalItems();
            LoadReorderRecommendations();
            UpdateSummaryCards();
        }

        private void LoadLastForecastAnalysis()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = @"
                    SELECT * FROM sales_forecast_analysis 
                    ORDER BY 
                        CASE priority_level 
                            WHEN 'CRITICAL' THEN 1 
                            WHEN 'HIGH' THEN 2 
                            WHEN 'MEDIUM' THEN 3 
                            ELSE 4 
                        END,
                        predicted_stockout_date";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvForecastResults.DataSource = dt;
                }

                FormatForecastGrid();
            }
            catch (Exception ex)
            {
                // In a UserControl, you might want to log this or expose an event
                // instead of showing a MessageBox directly.
                // MessageBox.Show($"Error loading forecast data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Error loading forecast data: {ex.Message}");
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void LoadCriticalItems()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = @"
                    SELECT prod_name, current_stock, avg_daily_sales, 
                           predicted_stockout_date, priority_level
                    FROM sales_forecast_analysis 
                    WHERE priority_level IN ('CRITICAL', 'HIGH')
                    ORDER BY predicted_stockout_date";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvCriticalItems.DataSource = dt;
                }

                FormatCriticalItemsGrid();
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void LoadReorderRecommendations()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = @"
                    SELECT prod_name, category, current_stock, reorder_point,
                           recommended_order_qty, predicted_stockout_date
                    FROM sales_forecast_analysis 
                    WHERE current_stock <= reorder_point OR priority_level IN ('CRITICAL', 'HIGH')
                    ORDER BY priority_level, predicted_stockout_date";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgvReorderRecommendations.DataSource = dt;
                }

                FormatReorderGrid();
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void FormatForecastGrid()
        {
            if (dgvForecastResults.Columns.Count > 0)
            {
                dgvForecastResults.Columns["prod_name"].HeaderText = "Product Name";
                dgvForecastResults.Columns["category"].HeaderText = "Category";
                dgvForecastResults.Columns["current_stock"].HeaderText = "Current Stock";
                dgvForecastResults.Columns["avg_daily_sales"].HeaderText = "Avg Daily Sales";
                dgvForecastResults.Columns["predicted_stockout_date"].HeaderText = "Predicted Stockout";
                dgvForecastResults.Columns["reorder_point"].HeaderText = "Reorder Point";
                dgvForecastResults.Columns["recommended_order_qty"].HeaderText = "Recommended Order";
                dgvForecastResults.Columns["priority_level"].HeaderText = "Priority";
                dgvForecastResults.Columns["forecast_accuracy"].HeaderText = "Accuracy %";

                // Hide ID columns
                if (dgvForecastResults.Columns["id"] != null)
                    dgvForecastResults.Columns["id"].Visible = false;
                if (dgvForecastResults.Columns["prod_id"] != null)
                    dgvForecastResults.Columns["prod_id"].Visible = false;
                if (dgvForecastResults.Columns["analysis_date"] != null)
                    dgvForecastResults.Columns["analysis_date"].Visible = false;
                if (dgvForecastResults.Columns["last_updated"] != null)
                    dgvForecastResults.Columns["last_updated"].Visible = false;

                // Color code priority levels
                foreach (DataGridViewRow row in dgvForecastResults.Rows)
                {
                    if (row.Cells["priority_level"].Value != null)
                    {
                        string priority = row.Cells["priority_level"].Value.ToString();
                        switch (priority)
                        {
                            case "CRITICAL":
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 235, 235);
                                row.DefaultCellStyle.ForeColor = Color.FromArgb(183, 28, 28);
                                break;
                            case "HIGH":
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 243, 224);
                                row.DefaultCellStyle.ForeColor = Color.FromArgb(230, 81, 0);
                                break;
                            case "MEDIUM":
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 248, 225);
                                row.DefaultCellStyle.ForeColor = Color.FromArgb(239, 108, 0);
                                break;
                        }
                    }
                }
            }
        }

        private void FormatCriticalItemsGrid()
        {
            if (dgvCriticalItems.Columns.Count > 0)
            {
                dgvCriticalItems.Columns["prod_name"].HeaderText = "Product";
                dgvCriticalItems.Columns["current_stock"].HeaderText = "Stock";
                dgvCriticalItems.Columns["avg_daily_sales"].HeaderText = "Daily Sales";
                dgvCriticalItems.Columns["predicted_stockout_date"].HeaderText = "Stockout Date";
                dgvCriticalItems.Columns["priority_level"].HeaderText = "Priority";
            }
        }

        private void FormatReorderGrid()
        {
            if (dgvReorderRecommendations.Columns.Count > 0)
            {
                dgvReorderRecommendations.Columns["prod_name"].HeaderText = "Product";
                dgvReorderRecommendations.Columns["category"].HeaderText = "Category";
                dgvReorderRecommendations.Columns["current_stock"].HeaderText = "Current Stock";
                dgvReorderRecommendations.Columns["reorder_point"].HeaderText = "Reorder Point";
                dgvReorderRecommendations.Columns["recommended_order_qty"].HeaderText = "Order Quantity";
                dgvReorderRecommendations.Columns["predicted_stockout_date"].HeaderText = "Stockout Date";
            }
        }

        private void UpdateSummaryCards()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                // Total products analyzed
                string totalQuery = "SELECT COUNT(*) FROM sales_forecast_analysis";
                using (SqlCommand cmd = new SqlCommand(totalQuery, connect))
                {
                    lblTotalProducts.Text = cmd.ExecuteScalar().ToString();
                }

                // Critical items count
                string criticalQuery = "SELECT COUNT(*) FROM sales_forecast_analysis WHERE priority_level = 'CRITICAL'";
                using (SqlCommand cmd = new SqlCommand(criticalQuery, connect))
                {
                    lblCriticalItems.Text = cmd.ExecuteScalar().ToString();
                }

                // Items needing reorder
                string reorderQuery = "SELECT COUNT(*) FROM sales_forecast_analysis WHERE current_stock <= reorder_point";
                using (SqlCommand cmd = new SqlCommand(reorderQuery, connect))
                {
                    lblReorderItems.Text = cmd.ExecuteScalar().ToString();
                }

                // Average forecast accuracy
                string accuracyQuery = "SELECT AVG(forecast_accuracy) FROM sales_forecast_analysis";
                using (SqlCommand cmd = new SqlCommand(accuracyQuery, connect))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                        lblAvgAccuracy.Text = $"{Convert.ToDouble(result):F1}%";
                    else
                        lblAvgAccuracy.Text = "N/A";
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void UpdateLastAnalysisLabel()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string query = "SELECT TOP 1 analysis_date FROM sales_forecast_analysis ORDER BY analysis_date DESC";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    var result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        DateTime lastAnalysis = Convert.ToDateTime(result);
                        TimeSpan timeDiff = DateTime.Now - lastAnalysis;
                        if (timeDiff.TotalMinutes < 1)
                            lblLastUpdated.Text = "Last updated: Just now";
                        else if (timeDiff.TotalHours < 1)
                            lblLastUpdated.Text = $"Last updated: {(int)timeDiff.TotalMinutes} minutes ago";
                        else if (timeDiff.TotalDays < 1)
                            lblLastUpdated.Text = $"Last updated: {(int)timeDiff.TotalHours} hours ago";
                        else
                            lblLastUpdated.Text = $"Last updated: {lastAnalysis:MMM dd, yyyy 'at' h:mm tt}";
                    }
                    else
                    {
                        lblLastUpdated.Text = "No analysis performed yet";
                    }
                }
            }
            catch
            {
                lblLastUpdated.Text = "Last updated: Unknown";
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void SaveAnalysisToHistory(int totalProducts)
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                int criticalCount = 0, reorderCount = 0;

                // Get counts
                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM sales_forecast_analysis WHERE priority_level = 'CRITICAL'", connect))
                {
                    criticalCount = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM sales_forecast_analysis WHERE current_stock <= reorder_point", connect))
                {
                    reorderCount = Convert.ToInt32(cmd.ExecuteScalar());
                }

                string insights = GenerateInsightsSummary(totalProducts, criticalCount, reorderCount);

                string insertQuery = @"
                    INSERT INTO forecast_history (analysis_date, total_products_analyzed, critical_items_count, reorder_recommendations, insights_summary)
                    VALUES (@analysisDate, @totalProducts, @criticalCount, @reorderCount, @insights)";

                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@analysisDate", DateTime.Now);
                    cmd.Parameters.AddWithValue("@totalProducts", totalProducts);
                    cmd.Parameters.AddWithValue("@criticalCount", criticalCount);
                    cmd.Parameters.AddWithValue("@reorderCount", reorderCount);
                    cmd.Parameters.AddWithValue("@insights", insights);

                    cmd.ExecuteNonQuery();
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private string GenerateInsightsSummary(int totalProducts, int criticalCount, int reorderCount)
        {
            StringBuilder summary = new StringBuilder();
            summary.AppendLine($"Analysis Date: {DateTime.Now:yyyy-MM-dd HH:mm:ss}");
            summary.AppendLine($"Total Products Analyzed: {totalProducts}");
            summary.AppendLine($"Critical Items: {criticalCount}");
            summary.AppendLine($"Reorder Recommendations Issued: {reorderCount}");

            if (criticalCount > 0)
            {
                summary.AppendLine("Immediate action needed for critical items to prevent stockouts.");
            }
            if (reorderCount > 0)
            {
                summary.AppendLine("Review reorder recommendations to maintain optimal stock levels.");
            }
            if (totalProducts > 0 && criticalCount == 0 && reorderCount == 0)
            {
                summary.AppendLine("Inventory levels appear healthy with no immediate critical or reorder needs.");
            }
            else if (totalProducts == 0)
            {
                summary.AppendLine("No product data available for analysis.");
            }

            return summary.ToString();
        }

        private void btnRefreshData_Click(object sender, EventArgs e)
        {
            LoadForecastResults();
        }

        private void btnExportReport_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "CSV files (*.csv)|*.csv";
                saveFile.FileName = $"SalesForecastReport_{DateTime.Now:yyyyMMddHHmmss}.csv";

                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StringBuilder csv = new StringBuilder();

                    // Add header
                    foreach (DataGridViewColumn column in dgvForecastResults.Columns)
                    {
                        if (column.Visible) // Only export visible columns
                            csv.AppendFormat("\"{0}\",", column.HeaderText);
                    }
                    csv.AppendLine();

                    // Add rows
                    foreach (DataGridViewRow row in dgvForecastResults.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                if (dgvForecastResults.Columns[cell.ColumnIndex].Visible) // Only export visible columns
                                    csv.AppendFormat("\"{0}\",", cell.Value?.ToString().Replace("\"", "\"\""));
                            }
                            csv.AppendLine();
                        }
                    }

                    File.WriteAllText(saveFile.FileName, csv.ToString(), Encoding.UTF8);
                    MessageBox.Show("Report exported successfully!", "Export Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear all analysis history? This action cannot be undone.",
                "Confirm Clear History", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ClearAllHistory();
                LoadForecastResults(); // Refresh display after clearing
                UpdateLastAnalysisLabel(); // Update last analysis date
            }
        }

        private void ClearAllHistory()
        {
            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                using (SqlCommand cmd = new SqlCommand("DELETE FROM sales_forecast_analysis; DELETE FROM forecast_history;", connect))
                {
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("All analysis history cleared successfully.", "History Cleared", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error clearing history: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        // Data classes for forecasting
        public class ProductSalesData
        {
            public string ProdId { get; set; }
            public string ProdName { get; set; }
            public string Category { get; set; }
            public int CurrentStock { get; set; }
            public double AvgDailySales { get; set; }
            public int TotalSales30Days { get; set; }
            public int ActiveSalesDays { get; set; }
        }

        public class ForecastResult
        {
            public string ProdId { get; set; }
            public string ProdName { get; set; }
            public string Category { get; set; }
            public int CurrentStock { get; set; }
            public double AvgDailySales { get; set; }
            public DateTime PredictedStockoutDate { get; set; }
            public int ReorderPoint { get; set; }
            public int RecommendedOrderQty { get; set; }
            public string PriorityLevel { get; set; }
            public double ForecastAccuracy { get; set; }
        }

        private void dgvCriticalItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblLastUpdated_Click(object sender, EventArgs e)
        {

        }
    }
}