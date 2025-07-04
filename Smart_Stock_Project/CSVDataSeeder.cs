using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;

namespace Smart_Stock_Project
{
    public partial class CSVDataSeeder : UserControl
    {
        private SqlConnection connect;
        private Dictionary<string, int> categoryIdMap = new Dictionary<string, int>();
        private Dictionary<string, string> productIdMap = new Dictionary<string, string>();
        private int customerIdCounter = 1; // This counter might need to be persistent across runs or reset intelligently.

        public CSVDataSeeder()
        {
            InitializeComponent();

            if (!IsInDesignMode())
            {
                // Ensure your connection string name matches what's in App.config/Web.config
                connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString);
                InitializeData();
            }
        }

        private bool IsInDesignMode()
        {
            return (LicenseManager.UsageMode == LicenseUsageMode.Designtime);
        }

        private void InitializeData()
        {
            try
            {
                SeedCategoriesAndProducts(); // Ensure categories and products are in DB
                LoadCategoryMapping();
                LoadProductMapping();
                LogMessage("System initialized successfully.", Color.Green);
            }
            catch (Exception ex)
            {
                LogMessage($"Initialization error: {ex.Message}", Color.Red);
            }
        }

        private void SeedCategoriesAndProducts()
        {
            try
            {
                connect.Open();

                // Check if categories already exist before inserting to avoid duplicates on every run
                string checkCategoriesQuery = "SELECT COUNT(*) FROM categories";
                using (SqlCommand cmd = new SqlCommand(checkCategoriesQuery, connect))
                {
                    int categoryCount = (int)cmd.ExecuteScalar();
                    if (categoryCount == 0)
                    {
                        InsertCategories();
                        InsertProducts();
                        LogMessage("Categories and Products seeded successfully.", Color.Green);
                    }
                    else
                    {
                        LogMessage("Categories and Products already exist, skipping seeding.", Color.Blue);
                    }
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Seeding error: {ex.Message}", Color.Red);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void InsertCategories()
        {
            string[] categories = {
                "HOTDOGS", "APPETIZERS", "CLASSIC REFRESHERS",
                "CREAMY INDULGENCES", "COFFEE CREATIONS", "MATCHA SPECIALS",
                "HOTDOG SANDWICHES",
                "ADD ONS"
            };

            string insertQuery = "INSERT INTO categories (category, date) VALUES (@category, @date)";

            foreach (string category in categories)
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@category", category);
                    cmd.Parameters.AddWithValue("@date", DateTime.Now.Date);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void InsertProducts()
        {
            var products = new List<(string category, string name, double price)>
            {
                // HOTDOGS
                ("HOTDOGS", "Plain Hotdog Sandwich", 55),
                ("HOTDOGS", "Signature Cheesy Hotdog Sandwich", 65),
                ("HOTDOGS", "Bacon Overload", 75),
                
                // HOTDOG SANDWICHES (from CSV)
                ("HOTDOG SANDWICHES", "CHEESY HOTDOG SANDWICH", 65),
                ("HOTDOG SANDWICHES", "COMBO PLAIN", 125),
                ("HOTDOG SANDWICHES", "COMBO TWISTER FRIES", 125),

                // APPETIZERS
                ("APPETIZERS", "Mojos - Plain (S)", 70),
                ("APPETIZERS", "Mojos - Plain (L)", 130),
                ("APPETIZERS", "Mojos - Buffalo (S)", 70),
                ("APPETIZERS", "Mojos - Buffalo (L)", 130),
                ("APPETIZERS", "BUFFALO MOJOS", 130),
                ("APPETIZERS", "PLAIN MOJOS", 130),
                ("APPETIZERS", "Twister Fries (S)", 70),
                ("APPETIZERS", "Twister Fries (L)", 130),
                ("APPETIZERS", "TWISTER FRIES", 70),
                ("APPETIZERS", "Cheesy Bacon Fries (S)", 70),
                ("APPETIZERS", "Cheesy Bacon Fries (L)", 130),
                ("APPETIZERS", "CHEESY BACON FRIES", 130),
                ("APPETIZERS", "Chicken Poppers (S)", 70),
                ("APPETIZERS", "Chicken Poppers (L)", 130),
                ("APPETIZERS", "CHICKEN POPPERS", 70),
                ("APPETIZERS", "CHICK N CHIPS", 150),
                
                // CLASSIC REFRESHERS
                ("CLASSIC REFRESHERS", "Strawberry Soda (S)", 45),
                ("CLASSIC REFRESHERS", "Strawberry Soda (L)", 55),
                ("CLASSIC REFRESHERS", "STRAWBERRY SODA", 55),
                ("CLASSIC REFRESHERS", "Blueberry Soda (S)", 45),
                ("CLASSIC REFRESHERS", "Blueberry Soda (L)", 55),
                ("CLASSIC REFRESHERS", "Green Apple Soda (S)", 45),
                ("CLASSIC REFRESHERS", "Green Apple Soda (L)", 55),
                ("CLASSIC REFRESHERS", "Classic Lemonade (S)", 55),
                ("CLASSIC REFRESHERS", "Classic Lemonade (L)", 65),
                ("CLASSIC REFRESHERS", "CLASSIC LEMONADE", 65),
                ("CLASSIC REFRESHERS", "Lemon Yakult (S)", 65),
                ("CLASSIC REFRESHERS", "Lemon Yakult (L)", 75),
                ("CLASSIC REFRESHERS", "LEMON YAKULT", 65),
                ("CLASSIC REFRESHERS", "Strawberry Lemon Yakult (S)", 75),
                ("CLASSIC REFRESHERS", "Strawberry Lemon Yakult (L)", 85),
                ("CLASSIC REFRESHERS", "STRAWBERRY LEMON YAKULT", 85),
                
                // CREAMY INDULGENCES
                ("CREAMY INDULGENCES", "Strawberry Milk (S)", 75),
                ("CREAMY INDULGENCES", "Strawberry Milk (L)", 85),
                ("CREAMY INDULGENCES", "STRAWBERRY MILK", 75),
                ("CREAMY INDULGENCES", "Mango Milk (S)", 75),
                ("CREAMY INDULGENCES", "Mango Milk (L)", 85),
                ("CREAMY INDULGENCES", "PEACH MANGO MILK", 95),
                ("CREAMY INDULGENCES", "Blueberry Milk (S)", 75),
                ("CREAMY INDULGENCES", "Blueberry Milk (L)", 85),
                ("CREAMY INDULGENCES", "BLUEBERRY MILK", 75),
                ("CREAMY INDULGENCES", "Chocolate Milk (S)", 75),
                
                // COFFEE CREATIONS
                ("COFFEE CREATIONS", "Cold Brew Coffee", 50),
                ("COFFEE CREATIONS", "Cold Brew Latte", 70),
                ("COFFEE CREATIONS", "Spanish Latte", 90),
                ("COFFEE CREATIONS", "Strawberry Mocha", 100),
                ("COFFEE CREATIONS", "Caramel Macchiato", 100),
                ("COFFEE CREATIONS", "White Chocolate Mocha", 100),
                
                // MATCHA SPECIALS
                ("MATCHA SPECIALS", "Milky Matcha", 120),
                ("MATCHA SPECIALS", "Dirty Matcha", 120),
                ("MATCHA SPECIALS", "Strawberry Matcha", 130),

                // ADD ONS (from CSV)
                ("ADD ONS", "DIP", 10),
                ("ADD ONS", "SYRUPS", 5),
                ("ADD ONS", "EXTRA SHOT ESPRESSO", 20)
            };

            string insertQuery = @"INSERT INTO products (prod_id, prod_name, category, price, stock, status, date_insert) 
                                     VALUES (@prod_id, @prod_name, @category, @price, @stock, @status, @date_insert)";

            int productCounter = 1;
            foreach (var product in products)
            {
                using (SqlCommand cmd = new SqlCommand(insertQuery, connect))
                {
                    cmd.Parameters.AddWithValue("@prod_id", $"PROD{productCounter:D3}");
                    cmd.Parameters.AddWithValue("@prod_name", product.name);
                    cmd.Parameters.AddWithValue("@category", product.category);
                    cmd.Parameters.AddWithValue("@price", product.price);
                    cmd.Parameters.AddWithValue("@stock", 100); // Default stock
                    cmd.Parameters.AddWithValue("@status", "Available");
                    cmd.Parameters.AddWithValue("@date_insert", DateTime.Now.Date);
                    try
                    {
                        cmd.ExecuteNonQuery();
                    }
                    catch (SqlException ex)
                    {
                        // Handle potential primary key violation if running multiple times without truncating products
                        LogMessage($"Could not insert product {product.name}: {ex.Message}", Color.Orange);
                    }
                }
                productCounter++;
            }
        }

        private void LoadCategoryMapping()
        {
            categoryIdMap.Clear(); // Clear existing map
            try
            {
                connect.Open();
                string query = "SELECT id, category FROM categories";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categoryIdMap[reader["category"].ToString().ToUpper()] = (int)reader["id"]; // Store category names in uppercase
                        }
                    }
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void LoadProductMapping()
        {
            productIdMap.Clear(); // Clear existing map
            try
            {
                connect.Open();
                string query = "SELECT prod_id, prod_name FROM products";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            productIdMap[reader["prod_name"].ToString().ToUpper()] = reader["prod_id"].ToString(); // Store product names in uppercase
                        }
                    }
                }
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                    btnUpload.Enabled = true;
                    LogMessage($"File selected: {openFileDialog.FileName}", Color.Blue);
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilePath.Text))
            {
                MessageBox.Show("Please select a CSV file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ProcessCSVFile(txtFilePath.Text);
        }

        private void ProcessCSVFile(string filePath)
        {
            try
            {
                btnUpload.Enabled = false;
                lblStatus.Text = "Processing CSV file...";

                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length <= 1)
                {
                    LogMessage("CSV file is empty or contains only headers.", Color.Red);
                    return;
                }

                progressBar.Maximum = lines.Length - 1;
                progressBar.Value = 0;

                // Dictionary to group items by Transaction ID
                // Key: Transaction ID, Value: List of (productName, category, price, quantity, date)
                var transactions = new Dictionary<string, List<(string productName, string category, double price, int quantity, DateTime date)>>();

                // Skip header line
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var columns = ParseCSVLine(line);

                    // Debug: Log the number of columns found for the first few rows
                    if (i <= 5) // Log first few data rows for debugging
                    {
                        LogMessage($"Line {i}: Found {columns.Length} columns.", Color.Blue);
                        LogMessage($"Line {i} content (first 15 columns): {string.Join(" | ", columns.Take(15))}", Color.Blue);
                    }


                    if (columns.Length < 13) // Ensure enough columns for Date, Time, Transaction ID, Category, Item, Quantity, Price per Unit
                    {
                        LogMessage($"Line {i + 1}: Insufficient columns ({columns.Length}). Expected at least 13. Skipping.", Color.Orange);
                        continue;
                    }

                    try
                    {
                        // Based on your CSV format:
                        // Date Time Transaction ID Receipt No. Total Total Cost Payment Type Category Item Option Modifier Quantity Price per Unit...
                        string dateStr = columns[0].Trim();
                        string timeStr = columns[1].Trim();
                        string transactionId = columns[2].Trim();
                        string category = columns[7].Trim();
                        string item = columns[8].Trim();
                        string option = columns.Length > 9 ? columns[9].Trim() : "";

                        // Parse quantity and price
                        int quantity = 1;
                        double price = 0;

                        // Quantity is at index 11, Price per Unit is at index 12
                        if (!string.IsNullOrWhiteSpace(columns[11]))
                        {
                            if (!int.TryParse(columns[11].Trim(), out quantity))
                            {
                                LogMessage($"Line {i + 1}: Could not parse quantity '{columns[11]}', defaulting to 1.", Color.Orange);
                                quantity = 1;
                            }
                        }
                        else
                        {
                            LogMessage($"Line {i + 1}: Quantity field is empty, defaulting to 1.", Color.Orange);
                        }


                        if (!string.IsNullOrWhiteSpace(columns[12]))
                        {
                            // Use CultureInfo.InvariantCulture to ensure consistent parsing of doubles
                            if (!double.TryParse(columns[12].Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out price))
                            {
                                LogMessage($"Line {i + 1}: Could not parse price '{columns[12]}', defaulting to 0.", Color.Orange);
                                price = 0;
                            }
                        }
                        else
                        {
                            LogMessage($"Line {i + 1}: Price per Unit field is empty, defaulting to 0.", Color.Orange);
                        }

                        // Handle negative quantity and price which might indicate refunds/returns
                        if (quantity < 0 || price < 0)
                        {
                            LogMessage($"Line {i + 1}: Found negative quantity ({quantity}) or price ({price}), indicating a return/refund. Skipping for initial import.", Color.Yellow);
                            continue; // Skip lines with negative values for initial order import
                        }

                        // Skip if essential fields are empty
                        if (string.IsNullOrWhiteSpace(transactionId) || string.IsNullOrWhiteSpace(item))
                        {
                            LogMessage($"Line {i + 1}: Missing essential data (TransactionID: '{transactionId}', Item: '{item}'). Skipping.", Color.Orange);
                            continue;
                        }

                        // Build full product name by combining Item and Option if Option is present and not "NULL"
                        string fullProductName = item.Trim();
                        if (!string.IsNullOrWhiteSpace(option) && !option.Equals("NULL", StringComparison.OrdinalIgnoreCase))
                        {
                            // Attempt to append option if it seems like a size or descriptive suffix
                            // This logic can be refined further based on your exact product naming conventions.
                            // For common sizes (S, L, OZ), append in parenthesis. Otherwise, just concatenate.
                            if (option.Equals("SMALL", StringComparison.OrdinalIgnoreCase) ||
                                option.Equals("LARGE", StringComparison.OrdinalIgnoreCase) ||
                                option.EndsWith("OZ", StringComparison.OrdinalIgnoreCase))
                            {
                                fullProductName = $"{item.Trim()} ({option.Trim()})";
                            }
                            else
                            {
                                fullProductName = $"{item.Trim()} {option.Trim()}";
                            }
                        }

                        // Normalize product names and categories to uppercase for consistent lookup
                        fullProductName = fullProductName.ToUpper();
                        category = category.ToUpper();

                        // Parse date
                        DateTime orderDate = ParseDate(dateStr);

                        // Group by transaction ID
                        if (!transactions.ContainsKey(transactionId))
                        {
                            transactions[transactionId] = new List<(string, string, double, int, DateTime)>();
                        }

                        transactions[transactionId].Add((fullProductName, category, price, quantity, orderDate));

                        // Debug: Log first few successful transaction items
                        if (transactions.Count <= 5) // Log only a few to avoid excessive logging
                        {
                            LogMessage($"Processed transaction item: {transactionId} - {fullProductName} (Category: {category}, Qty: {quantity}, Price: {price})", Color.Green);
                        }
                    }
                    catch (Exception ex)
                    {
                        LogMessage($"Error parsing line {i + 1}: {ex.Message}", Color.Orange);
                        // Debug: Show the problematic line content for the first few errors
                        if (i <= 5)
                        {
                            LogMessage($"Problematic line content: '{line}'", Color.Gray);
                        }
                    }

                    progressBar.Value = i;
                }

                LogMessage($"Found {transactions.Count} unique transactions to process.", Color.Blue);

                // Insert transactions into database
                if (transactions.Count > 0)
                {
                    InsertTransactions(transactions);
                    LogMessage($"Successfully processed {transactions.Count} unique transactions.", Color.Green);
                    lblStatus.Text = "Processing completed successfully!";
                }
                else
                {
                    LogMessage("No valid transactions found to process.", Color.Red);
                    lblStatus.Text = "No transactions processed.";
                }
            }
            catch (Exception ex)
            {
                LogMessage($"Error processing CSV: {ex.Message}", Color.Red);
                lblStatus.Text = "Error occurred during processing.";
            }
            finally
            {
                btnUpload.Enabled = true;
                progressBar.Value = 0; // Reset progress bar
            }
        }

        private string[] ParseCSVLine(string line)
        {
            // Use Split(',') as indicated by your CSV sample and typical CSV structure.
            // If fields can contain commas and are quoted (e.g., "Item, Name"),
            // a more robust CSV parser (like one using TextFieldParser from Microsoft.VisualBasic.FileIO)
            // would be necessary. For now, assuming simple comma-separated values.
            var columns = line.Split(',');

            // Trim whitespace and remove quotes from each column
            for (int i = 0; i < columns.Length; i++)
            {
                columns[i] = columns[i].Trim().Trim('"');
            }

            return columns;
        }

        private DateTime ParseDate(string dateStr)
        {
            try
            {
                // Prioritize "yyyy-MM-dd" as per your Python script's output
                string[] formats = { "yyyy-MM-dd", "dd-MMM-yy", "dd-MM-yyyy", "MM/dd/yyyy", "dd/MM/yyyy" };

                foreach (string format in formats)
                {
                    if (DateTime.TryParseExact(dateStr, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime result))
                    {
                        return result;
                    }
                }

                // Fallback to general parsing (less reliable but might catch other formats)
                if (DateTime.TryParse(dateStr, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime generalResult))
                {
                    return generalResult;
                }

                LogMessage($"Could not parse date: '{dateStr}'. Using current date as fallback.", Color.Orange);
                return DateTime.Now.Date; // Fallback
            }
            catch (Exception ex)
            {
                LogMessage($"Error during date parsing for '{dateStr}': {ex.Message}. Using current date as fallback.", Color.Orange);
                return DateTime.Now.Date;
            }
        }

        private void InsertTransactions(Dictionary<string, List<(string productName, string category, double price, int quantity, DateTime date)>> transactions)
        {
            try
            {
                connect.Open();
                int successfulTransactions = 0;

                // Use a transaction for batch insertion for better performance and atomicity
                using (SqlTransaction sqlTransaction = connect.BeginTransaction())
                {
                    try
                    {
                        // Get the maximum customer_id currently in the database to continue the sequence
                        string getMaxCustomerIdQuery = "SELECT ISNULL(MAX(customer_id), 0) FROM customers";
                        using (SqlCommand cmd = new SqlCommand(getMaxCustomerIdQuery, connect, sqlTransaction))
                        {
                            customerIdCounter = (int)cmd.ExecuteScalar() + 1;
                        }

                        foreach (var transactionGroup in transactions.Values) // Iterate through the lists of items grouped by transaction
                        {
                            // A single customer_id should represent a single transaction (order)
                            int currentCustomerId = customerIdCounter++;

                            // Calculate total_price for the entire transaction
                            double totalTransactionPrice = transactionGroup.Sum(item => item.price * item.quantity);

                            // The order_date for the transaction (assuming all items in a group have the same date)
                            DateTime transactionOrderDate = transactionGroup.First().date;

                            // Insert customer record for this transaction
                            string customerQuery = @"INSERT INTO customers (customer_id, total_price, amount, change_amount, order_date) 
                                                     VALUES (@customer_id, @total_price, @amount, @change_amount, @order_date)";
                            using (SqlCommand cmd = new SqlCommand(customerQuery, connect, sqlTransaction))
                            {
                                cmd.Parameters.AddWithValue("@customer_id", currentCustomerId);
                                cmd.Parameters.AddWithValue("@total_price", totalTransactionPrice);
                                cmd.Parameters.AddWithValue("@amount", totalTransactionPrice); // Assuming amount paid equals total price
                                cmd.Parameters.AddWithValue("@change_amount", 0); // Assuming no change
                                cmd.Parameters.AddWithValue("@order_date", transactionOrderDate);
                                cmd.ExecuteNonQuery();
                            }

                            // Insert order records for each item within this transaction
                            foreach (var item in transactionGroup)
                            {
                                string productId = GetProductId(item.productName);
                                if (productId != null)
                                {
                                    string orderQuery = @"INSERT INTO orders (customer_id, prod_id, prod_name, category, orig_price, quantity, total_price, order_date) 
                                                          VALUES (@customer_id, @prod_id, @prod_name, @category, @orig_price, @quantity, @total_price, @order_date)";
                                    using (SqlCommand cmd = new SqlCommand(orderQuery, connect, sqlTransaction))
                                    {
                                        cmd.Parameters.AddWithValue("@customer_id", currentCustomerId);
                                        cmd.Parameters.AddWithValue("@prod_id", productId);
                                        cmd.Parameters.AddWithValue("@prod_name", item.productName);
                                        cmd.Parameters.AddWithValue("@category", item.category);
                                        cmd.Parameters.AddWithValue("@orig_price", item.price);
                                        cmd.Parameters.AddWithValue("@quantity", item.quantity);
                                        cmd.Parameters.AddWithValue("@total_price", item.price * item.quantity);
                                        cmd.Parameters.AddWithValue("@order_date", item.date);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    LogMessage($"Product not found in mapping for '{item.productName}' (Category: {item.category}). Skipping order item.", Color.Orange);
                                }
                            }
                            successfulTransactions++;
                        }
                        sqlTransaction.Commit(); // Commit the transaction if all inserts are successful
                    }
                    catch (Exception ex)
                    {
                        sqlTransaction.Rollback(); // Rollback on error
                        LogMessage($"Error inserting transactions into database. Rolled back changes: {ex.Message}", Color.Red);
                        throw; // Re-throw to be caught by the outer catch block
                    }
                }
                LogMessage($"Successfully inserted {successfulTransactions} transactions into database.", Color.Green);
            }
            catch (Exception ex)
            {
                LogMessage($"Database error during transaction insertion: {ex.Message}", Color.Red);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private string GetProductId(string productName)
        {
            // Normalize product name for lookup (case-insensitive, trim)
            string normalizedProductName = productName.Trim().ToUpper();

            // Try exact match first (which is now case-insensitive due to ToUpper in LoadProductMapping)
            if (productIdMap.ContainsKey(normalizedProductName))
                return productIdMap[normalizedProductName];

            // If exact match fails, try a more flexible approach for common variations/sizes.
            // This attempts to match seeded products like "Mojos - Plain (S)" with "MOJOS - PLAIN" from CSV.
            foreach (var kvp in productIdMap)
            {
                // Remove common size suffixes from the stored product name for comparison
                string cleanStoredName = kvp.Key
                    .Replace(" (S)", "").Replace(" (L)", "")
                    .Replace(" (16OZ)", "").Replace(" (22OZ)", "")
                    .Trim();

                // If the cleaned stored name exactly matches the normalized product name from CSV,
                // or if the CSV product name (without its specific size) is contained within the stored name (and vice-versa, for robustness)
                if (normalizedProductName.Equals(cleanStoredName, StringComparison.OrdinalIgnoreCase) ||
                    normalizedProductName.Contains(cleanStoredName) ||
                    cleanStoredName.Contains(normalizedProductName))
                {
                    return kvp.Value;
                }
            }

            return null; // Return null if no product ID is found
        }

        private void LogMessage(string message, Color color)
        {
            if (rtbLog.InvokeRequired)
            {
                rtbLog.Invoke(new Action(() => LogMessage(message, color)));
                return;
            }

            rtbLog.SelectionStart = rtbLog.TextLength;
            rtbLog.SelectionLength = 0;
            rtbLog.SelectionColor = color;
            rtbLog.AppendText($"[{DateTime.Now:HH:mm:ss}] {message}\n");
            rtbLog.SelectionColor = rtbLog.ForeColor;
            rtbLog.ScrollToCaret();
        }
    }
}