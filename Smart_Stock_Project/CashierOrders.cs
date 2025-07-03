using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace Smart_Stock_Project
{
    public partial class CashierOrders : UserControl
    {
        SqlConnection connect;

        public CashierOrders()
        {
            InitializeComponent();

            if (!IsInDesignMode())
            {
                string connStr = ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"]?.ConnectionString;

                if (!string.IsNullOrEmpty(connStr))
                {
                    connect = new SqlConnection(connStr);

                    displayallAvailableProducts();
                    displayalCategories();
                    displayallOrders();
                    displayTotalPrice();
                }
            }
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            CheckAndUpdateZeroStockProducts();

            displayallAvailableProducts();
            displayalCategories();
            displayallOrders();
            displayTotalPrice();
        }

        private static bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                || System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
        }

        public void displayallAvailableProducts()
        {
            CheckAndUpdateZeroStockProducts();

            ProductsData apData = new ProductsData();
            List<ProductsData> listData = apData.allAvailableProductsData();

            dataGridView1.DataSource = listData;
        }

        public void displayallOrders()
        {
            IDGenerator(); // Ensure we have the current customer ID

            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM orders WHERE customer_id = @customer_id";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", idGen);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading orders: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        public bool CheckConnection()
        {
            if (connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayalCategories()
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM categories";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            cashierOrder_category.Items.Clear();
                            while (reader.Read())
                            {
                                string item = reader.GetString(1);
                                cashierOrder_category.Items.Add(item);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodID.Items.Clear();
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";

            string selectedValue = cashierOrder_category.SelectedItem as string;
            if (selectedValue != null)
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE category = '{selectedValue}' AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    cashierOrder_prodID.Items.Add(value);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private float totalPrice = 0;

        public void displayTotalPrice()
        {
            IDGenerator();
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT SUM(total_price) FROM orders WHERE customer_id = @customer_id";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", idGen);
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);
                            cashierOrder_totalPrice.Text = totalPrice.ToString("F2");
                        }
                        else
                        {
                            totalPrice = 0;
                            cashierOrder_totalPrice.Text = "0.00";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private void cashierOrder_AddBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            if (cashierOrder_category.SelectedIndex == -1 || cashierOrder_prodID.SelectedIndex == -1 || cashierOrder_prodName.Text == "" || cashierOrder_price.Text == "" ||
                cashierOrder_qty.Value == 0)
            {
                MessageBox.Show("Please select item first.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // ADD STOCK VALIDATION
                string selectedProductId = cashierOrder_prodID.SelectedItem.ToString();
                int availableStock = GetProductStock(selectedProductId);
                int requestedQuantity = (int)cashierOrder_qty.Value;

                if (requestedQuantity > availableStock)
                {
                    MessageBox.Show($"Insufficient stock! Available stock: {availableStock}, Requested: {requestedQuantity}",
                        "Stock Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();

                        float getPrice = 0;
                        string selectOrder = "SELECT price FROM products WHERE prod_id = @prod_id AND status = @status";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prod_id", cashierOrder_prodID.SelectedItem.ToString());
                            getOrder.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object priceObj = reader["price"];

                                    if (priceObj != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(priceObj);
                                    }
                                    else
                                    {
                                        MessageBox.Show("Price not found for the selected product.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        return;
                                    }
                                }
                            }
                        }

                        string inserData = "INSERT INTO orders (customer_id, prod_id, prod_name, category, orig_price, quantity, total_price, order_date) " +
                            "VALUES (@customer_id, @prod_id, @prod_name, @category, @orig_price, @quantity, @total_price, @order_date)";

                        using (SqlCommand cmd = new SqlCommand(inserData, connect))
                        {
                            cmd.Parameters.AddWithValue("@customer_id", idGen);
                            cmd.Parameters.AddWithValue("@prod_id", cashierOrder_prodID.SelectedItem);
                            cmd.Parameters.AddWithValue("@prod_name", cashierOrder_prodName.Text.Trim());
                            cmd.Parameters.AddWithValue("@category", cashierOrder_category.SelectedItem);
                            cmd.Parameters.AddWithValue("@orig_price", getPrice);
                            cmd.Parameters.AddWithValue("@quantity", cashierOrder_qty.Value);

                            float totalPrice = (getPrice * (int)cashierOrder_qty.Value);

                            cmd.Parameters.AddWithValue("@total_price", totalPrice);
                            cmd.Parameters.AddWithValue("@order_date", DateTime.Today);
                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Order Added Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                IDGenerator();
                                displayallAvailableProducts();
                                cashierOrder_prodID.SelectedIndex = -1;
                                cashierOrder_prodName.Text = "";
                                cashierOrder_price.Text = "";
                                cashierOrder_qty.Value = 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
            displayallOrders();
            displayTotalPrice();
        }



        //Get current stock for a product
        private int GetProductStock(string productId)
        {
            int currentStock = 0;
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    string selectStock = "SELECT stock FROM products WHERE prod_id = @prod_id AND status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectStock, connect))
                    {
                        cmd.Parameters.AddWithValue("@prod_id", productId);
                        cmd.Parameters.AddWithValue("@status", "Available");

                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            currentStock = Convert.ToInt32(result);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting stock: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return currentStock;
        }

        //Update product status when stock reaches 0
        private void UpdateProductStatus(string productId)
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    // Check current stock after update
                    string checkStock = "SELECT stock FROM products WHERE prod_id = @prod_id";
                    using (SqlCommand checkCmd = new SqlCommand(checkStock, connect))
                    {
                        checkCmd.Parameters.AddWithValue("@prod_id", productId);
                        object result = checkCmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            int currentStock = Convert.ToInt32(result);
                            if (currentStock <= 0)
                            {
                                // Update status to Unavailable
                                string updateStatus = "UPDATE products SET status = @status WHERE prod_id = @prod_id";
                                using (SqlCommand updateCmd = new SqlCommand(updateStatus, connect))
                                {
                                    updateCmd.Parameters.AddWithValue("@status", "Unavailable");
                                    updateCmd.Parameters.AddWithValue("@prod_id", productId);
                                    updateCmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating product status: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }


        //Check all products and update status for those with 0 stock
        private void CheckAndUpdateZeroStockProducts()
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    // Update all products with 0 stock to Unavailable
                    string updateZeroStock = "UPDATE products SET status = @unavailable WHERE stock <= 0 AND status = @available";
                    using (SqlCommand cmd = new SqlCommand(updateZeroStock, connect))
                    {
                        cmd.Parameters.AddWithValue("@unavailable", "Unavailable");
                        cmd.Parameters.AddWithValue("@available", "Available");
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error checking zero stock products: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        private int idGen;

        public void IDGenerator()
        {
            using (SqlConnection
            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString))
            {
                connect.Open();
                string selectData = "SELECT MAX(customer_id) FROM customers";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                }
            }
        }

        private void cashierOrder_prodID_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cashierOrder_prodID.SelectedItem as string;

            if (CheckConnection())
            {
                if (selectedValue != null)
                {
                    try
                    {
                        connect.Open();
                        string selectData = $"SELECT * FROM products WHERE prod_id = '{selectedValue}' AND status = @status";
                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@status", "Available");
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodName = reader["prod_name"].ToString();
                                    float price = Convert.ToSingle(reader["price"]);

                                    cashierOrder_prodName.Text = prodName;
                                    cashierOrder_price.Text = price.ToString("F2");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private int prodID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cashierOrder_RemoveBtn_Click(object sender, EventArgs e)
        {
            if (prodID == 0)
            {
                MessageBox.Show("Please select an item to remove.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to remove this item?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();
                            string deleteData = "DELETE FROM orders WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", prodID);
                                int rowsAffected = cmd.ExecuteNonQuery();
                                if (rowsAffected > 0)
                                {
                                    MessageBox.Show("Order Removed Successfully.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayallOrders();
                                    displayTotalPrice();
                                    prodID = 0;
                                }
                                else
                                {
                                    MessageBox.Show("No order found with the specified ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Failed Connection: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }
            }
            displayallOrders();
            displayTotalPrice();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the click is on a valid row (not header)
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                try
                {
                    DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

                    // Check if the row is not empty and has values
                    if (row.Cells.Count > 0 && row.Cells[0].Value != null)
                    {
                        // Try to get the ID from the first column
                        if (int.TryParse(row.Cells[0].Value.ToString(), out int id))
                        {
                            prodID = id;
                        }
                        else
                        {
                            // If first column is not an integer, try to find ID column by name
                            if (dataGridView2.Columns.Contains("ID") && row.Cells["ID"].Value != null)
                            {
                                if (int.TryParse(row.Cells["ID"].Value.ToString(), out int idByName))
                                {
                                    prodID = idByName;
                                }
                            }
                            else if (dataGridView2.Columns.Contains("id") && row.Cells["id"].Value != null)
                            {
                                if (int.TryParse(row.Cells["id"].Value.ToString(), out int idByNameLower))
                                {
                                    prodID = idByNameLower;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Unable to identify the order ID. Please check the data structure.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                prodID = 0;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting order: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    prodID = 0;
                }
            }
        }

        public void ClearFields()
        {
            cashierOrder_category.SelectedIndex = -1;
            cashierOrder_prodID.SelectedIndex = -1;
            cashierOrder_prodName.Text = "";
            cashierOrder_price.Text = "";
            cashierOrder_qty.Value = 0;
            cashierOrder_amount.Text = "";
            cashierOrder_change.Text = "";
        }

        private void cashierOrder_ClearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        //calculate change
        private void CalculateChange()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(cashierOrder_amount.Text))
                {
                    decimal getAmount = Convert.ToDecimal(cashierOrder_amount.Text);
                    decimal totalPriceDecimal = Convert.ToDecimal(totalPrice);
                    decimal getChange = (getAmount - totalPriceDecimal);

                    if (getChange < 0)
                    {
                        cashierOrder_change.Text = "";
                    }
                    else
                    {
                        cashierOrder_change.Text = getChange.ToString("F2");
                    }
                }
                else
                {
                    cashierOrder_change.Text = "";
                }
            }
            catch
            {
                cashierOrder_change.Text = "";
            }
        }

        //clear current orders from database
        private void ClearCurrentOrders()
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();
                    string deleteData = "DELETE FROM orders WHERE customer_id = @customer_id";

                    using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                    {
                        cmd.Parameters.AddWithValue("@customer_id", idGen);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error clearing orders: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        //pay orders method
        private void cashierOrder_payOrders_Click(object sender, EventArgs e)
        {
            IDGenerator();

            //change is calculated
            CalculateChange();

            if (string.IsNullOrWhiteSpace(cashierOrder_amount.Text) ||
                cashierOrder_amount.Text == "0" ||
                dataGridView2.Rows.Count <= 0)
            {
                MessageBox.Show("Please enter a valid amount and ensure there are items to pay for.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate that amount is sufficient
            try
            {
                decimal amountValue = Convert.ToDecimal(cashierOrder_amount.Text);
                decimal totalPriceDecimal = Convert.ToDecimal(totalPrice);

                if (amountValue < totalPriceDecimal)
                {
                    MessageBox.Show($"Insufficient payment. Total is ₱{totalPriceDecimal:F2}, but only ₱{amountValue:F2} was entered.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid amount format. Please enter a valid number.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to pay for the orders?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();

                        //collect order data before any deletions
                        List<(string productID, int quantity)> orderItems = new List<(string, int)>();

                        // Get current orders data from database
                        string selectOrdersData = "SELECT prod_id, quantity FROM orders WHERE customer_id = @customer_id";
                        using (SqlCommand selectCmd = new SqlCommand(selectOrdersData, connect))
                        {
                            selectCmd.Parameters.AddWithValue("@customer_id", idGen);
                            using (SqlDataReader reader = selectCmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string prodId = reader["prod_id"].ToString();
                                    int quantity = Convert.ToInt32(reader["quantity"]);
                                    orderItems.Add((prodId, quantity));
                                }
                            }
                        }

                        // Insert payment record
                        string insertData = "INSERT INTO customers (customer_id, total_price, amount, change_amount, order_date) " +
                            "VALUES (@customer_id, @total_price, @amount, @change_amount, @order_date)";

                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            decimal totalPriceValue = Convert.ToDecimal(cashierOrder_totalPrice.Text);
                            decimal amountValue = Convert.ToDecimal(cashierOrder_amount.Text);
                            decimal changeValue = Convert.ToDecimal(cashierOrder_change.Text);

                            cmd.Parameters.AddWithValue("@customer_id", idGen);
                            cmd.Parameters.AddWithValue("@total_price", totalPriceValue);
                            cmd.Parameters.AddWithValue("@amount", amountValue);
                            cmd.Parameters.AddWithValue("@change_amount", changeValue);
                            cmd.Parameters.AddWithValue("@order_date", DateTime.Today);

                            int rowsAffected = cmd.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                // Update product stocks using the collected order data
                                foreach (var item in orderItems)
                                {
                                    string updateStockQuery = "UPDATE products SET stock = stock - @quantity WHERE prod_id = @prod_id";
                                    using (SqlCommand updateCmd = new SqlCommand(updateStockQuery, connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@quantity", item.quantity);
                                        updateCmd.Parameters.AddWithValue("@prod_id", item.productID);
                                        int stockUpdateResult = updateCmd.ExecuteNonQuery();

                                        // Check if stock update was successful
                                        if (stockUpdateResult == 0)
                                        {
                                            MessageBox.Show($"Warning: Could not update stock for product {item.productID}", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }

                                    UpdateProductStatus(item.productID);
                                }

                                // Clear the current orders from the database
                                string deleteOrdersData = "DELETE FROM orders WHERE customer_id = @customer_id";
                                using (SqlCommand deleteCmd = new SqlCommand(deleteOrdersData, connect))
                                {
                                    deleteCmd.Parameters.AddWithValue("@customer_id", idGen);
                                    deleteCmd.ExecuteNonQuery();
                                }

                                MessageBox.Show("Payment Successful.", "Success Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Clear all fields and reset UI
                                ClearFields();
                                prodID = 0;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Failed Connection: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        if (connect.State == ConnectionState.Open)
                            connect.Close();
                    }
                }

                // Refresh displays AFTER connection is closed
                displayallOrders();
                displayTotalPrice();
                displayallAvailableProducts(); // This will show updated stock levels
            }
        }



        private void cashierOrder_amount_TextChanged(object sender, EventArgs e)
        {
            CalculateChange();
        }

        private void cashierOrder_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateChange(); // Calculate change on Enter
            }
        }

        // Format amount input when user leaves the textbox
        private void cashierOrder_amount_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(cashierOrder_amount.Text))
            {
                try
                {
                    decimal amount = Convert.ToDecimal(cashierOrder_amount.Text);
                    cashierOrder_amount.Text = amount.ToString("F2");
                    CalculateChange(); // Recalculate after formatting
                }
                catch
                {
                    // If conversion fails, leave as is or clear
                }
            }
        }

        // Restrict input to only numbers and one decimal point
        private void cashierOrder_amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys 
            if (char.IsControl(e.KeyChar))
                return;

            // Allow digits
            if (char.IsDigit(e.KeyChar))
                return;

            // Allow decimal point, but only one
            if (e.KeyChar == '.' && !cashierOrder_amount.Text.Contains("."))
                return;

            // Block all other characters
            e.Handled = true;
        }

        private int rowIndex = 0;


        private void cashierOrder_receipt_Click(object sender, EventArgs e)
        {
            // VALIDATION: Check if there are orders to print
            if (dataGridView2.Rows.Count <= 0)
            {
                MessageBox.Show("No items found in the order list.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDATION: Check if amount is entered and valid
            if (string.IsNullOrWhiteSpace(cashierOrder_amount.Text) || cashierOrder_amount.Text == "0")
            {
                MessageBox.Show("Please enter a valid amount before printing the receipt.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDATION: Check if amount is numeric
            if (!decimal.TryParse(cashierOrder_amount.Text.Trim(), out decimal inputAmount))
            {
                MessageBox.Show("Invalid amount format. Please enter numbers only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // VALIDATION: Check if amount is sufficient
            decimal totalPriceDecimal = Convert.ToDecimal(totalPrice);
            if (inputAmount < totalPriceDecimal)
            {
                MessageBox.Show($"Insufficient payment. Total is ₱{totalPriceDecimal:F2}, but only ₱{inputAmount:F2} was entered.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Calculate and display change
            decimal change = inputAmount - totalPriceDecimal;
            cashierOrder_change.Text = change.ToString("F2");

            var confirm = MessageBox.Show("Print receipt now?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.No) return;

            // Configure print document
            printDocument1.PrintPage -= printDocument1_PrintPage; // Remove any existing handlers
            printDocument1.BeginPrint -= printDocument1_BeginPrint;

            printDocument1.PrintPage += printDocument1_PrintPage;
            printDocument1.BeginPrint += printDocument1_BeginPrint;

            // Show print preview
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            rowIndex = 0; // Reset row index for each print job
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Ensure we have the latest total price
            displayTotalPrice();

            // Font definitions
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font regularFont = new Font("Arial", 10);
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            Font footerFont = new Font("Arial", 9);

            // Layout settings
            float yPos = e.MarginBounds.Top;
            float leftMargin = e.MarginBounds.Left;
            float pageWidth = e.MarginBounds.Width;
            float lineHeight = regularFont.GetHeight(e.Graphics);

            // String format for center alignment
            StringFormat centerFormat = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            StringFormat rightFormat = new StringFormat
            {
                Alignment = StringAlignment.Far,
                LineAlignment = StringAlignment.Center
            };

            // 1. HEADER SECTION
            string businessName = "Smart Stock Inventory System";
            string receiptTitle = "CASHIER RECEIPT";

            e.Graphics.DrawString(businessName, headerFont, Brushes.Black,
                leftMargin + (pageWidth / 2), yPos, centerFormat);
            yPos += headerFont.GetHeight(e.Graphics) + 5;

            e.Graphics.DrawString(receiptTitle, subHeaderFont, Brushes.Black,
                leftMargin + (pageWidth / 2), yPos, centerFormat);
            yPos += subHeaderFont.GetHeight(e.Graphics) + 10;

            // Date and Customer ID
            IDGenerator(); // Ensure we have current customer ID
            string dateTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            string customerInfo = $"Customer ID: {idGen}";

            e.Graphics.DrawString(dateTime, regularFont, Brushes.Black, leftMargin, yPos);
            e.Graphics.DrawString(customerInfo, regularFont, Brushes.Black, leftMargin + pageWidth, yPos, rightFormat);
            yPos += lineHeight + 10;

            // Separator line
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
            yPos += 10;

            // 2. ITEMS SECTION
            e.Graphics.DrawString("ITEMS ORDERED:", boldFont, Brushes.Black, leftMargin, yPos);
            yPos += lineHeight + 5;

            // Column headers
            string[] headers = { "Item", "Qty", "Price", "Total" };
            float[] columnWidths = { pageWidth * 0.5f, pageWidth * 0.15f, pageWidth * 0.175f, pageWidth * 0.175f };
            float[] columnPositions = new float[4];

            columnPositions[0] = leftMargin;
            for (int i = 1; i < columnPositions.Length; i++)
            {
                columnPositions[i] = columnPositions[i - 1] + columnWidths[i - 1];
            }

            // Draw headers
            for (int i = 0; i < headers.Length; i++)
            {
                StringFormat headerFormat = (i == 0) ? new StringFormat() : rightFormat;
                e.Graphics.DrawString(headers[i], boldFont, Brushes.Black,
                    columnPositions[i] + (i == 0 ? 0 : columnWidths[i]), yPos, headerFormat);
            }
            yPos += lineHeight + 3;

            // Draw separator
            e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
            yPos += 8;

            // 3. ITEMS DATA
            float itemSectionBottom = e.MarginBounds.Bottom - 150; // Reserve space for footer

            while (rowIndex < dataGridView2.Rows.Count)
            {
                if (yPos > itemSectionBottom)
                {
                    e.HasMorePages = true;
                    return; // Continue on next page
                }

                DataGridViewRow row = dataGridView2.Rows[rowIndex];

                // Extract data safely - CORRECTED VERSION
                string productName = "";
                string quantity = "0";
                string origPrice = "0.00";
                string totalPrice = "0.00";

                try
                {
                    // Method 1: Try to find columns by name (case-insensitive)
                    bool foundProductName = false;
                    bool foundQuantity = false;
                    bool foundOrigPrice = false;
                    bool foundTotalPrice = false;

                    for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    {
                        string columnName = dataGridView2.Columns[i].Name.ToLower();

                        if ((columnName.Contains("prod_name") || columnName.Contains("product") || columnName.Contains("name")) && !foundProductName)
                        {
                            productName = row.Cells[i].Value?.ToString() ?? "";
                            foundProductName = true;
                        }
                        else if ((columnName.Contains("quantity") || columnName.Contains("qty")) && !foundQuantity)
                        {
                            quantity = row.Cells[i].Value?.ToString() ?? "0";
                            foundQuantity = true;
                        }
                        else if ((columnName.Contains("orig_price") || (columnName.Contains("price") && !columnName.Contains("total"))) && !foundOrigPrice)
                        {
                            if (float.TryParse(row.Cells[i].Value?.ToString(), out float price))
                            {
                                origPrice = price.ToString("F2");
                                foundOrigPrice = true;
                            }
                        }
                        else if ((columnName.Contains("total_price") || columnName.Contains("total")) && !foundTotalPrice)
                        {
                            if (float.TryParse(row.Cells[i].Value?.ToString(), out float total))
                            {
                                totalPrice = total.ToString("F2");
                                foundTotalPrice = true;
                            }
                        }
                    }

                    // Method 2: Fallback to expected indices if names don't work
                    // Based on typical OrdersData structure: ID, CustomerID, ProdID, ProdName, Category, OrigPrice, Quantity, TotalPrice, OrderDate
                    if (!foundProductName && row.Cells.Count > 3)
                    {
                        productName = row.Cells[3].Value?.ToString() ?? ""; // ProdName is usually at index 3
                    }
                    if (!foundQuantity && row.Cells.Count > 6)
                    {
                        quantity = row.Cells[6].Value?.ToString() ?? "0"; // Quantity is usually at index 6
                    }
                    if (!foundOrigPrice && row.Cells.Count > 5)
                    {
                        if (float.TryParse(row.Cells[5].Value?.ToString(), out float price))
                        {
                            origPrice = price.ToString("F2"); // OrigPrice is usually at index 5
                        }
                    }
                    if (!foundTotalPrice && row.Cells.Count > 7)
                    {
                        if (float.TryParse(row.Cells[7].Value?.ToString(), out float total))
                        {
                            totalPrice = total.ToString("F2"); // TotalPrice is usually at index 7
                        }
                    }

                    // Additional validation - ensure we have at least basic data
                    if (string.IsNullOrEmpty(productName))
                    {
                        productName = "Unknown Item";
                    }
                    if (quantity == "0" || string.IsNullOrEmpty(quantity))
                    {
                        quantity = "1";
                    }
                    if (origPrice == "0.00" && !string.IsNullOrEmpty(totalPrice) && totalPrice != "0.00")
                    {
                        // Calculate original price from total and quantity if possible
                        if (float.TryParse(totalPrice, out float total) && int.TryParse(quantity, out int qty) && qty > 0)
                        {
                            origPrice = (total / qty).ToString("F2");
                        }
                    }
                }
                catch (Exception ex)
                {
                    // If all else fails, use basic row data
                    productName = "Item Error";
                    quantity = "1";
                    origPrice = "0.00";
                    totalPrice = "0.00";
                }

                // Draw item data
                e.Graphics.DrawString(productName, regularFont, Brushes.Black, columnPositions[0], yPos);
                e.Graphics.DrawString(quantity, regularFont, Brushes.Black,
                    columnPositions[1] + columnWidths[1], yPos, rightFormat);
                e.Graphics.DrawString("₱" + origPrice, regularFont, Brushes.Black,
                    columnPositions[2] + columnWidths[2], yPos, rightFormat);
                e.Graphics.DrawString("₱" + totalPrice, regularFont, Brushes.Black,
                    columnPositions[3] + columnWidths[3], yPos, rightFormat);

                yPos += lineHeight + 2;
                rowIndex++;
            }

            // 4. FOOTER SECTION (only on last page)
            if (rowIndex >= dataGridView2.Rows.Count)
            {
                yPos += 10;
                e.Graphics.DrawLine(Pens.Black, leftMargin, yPos, leftMargin + pageWidth, yPos);
                yPos += 10;

                // Parse amounts safely
                decimal amountValue = decimal.TryParse(cashierOrder_amount.Text.Trim(), out amountValue) ? amountValue : 0;
                decimal changeValue = decimal.TryParse(cashierOrder_change.Text, out changeValue) ? changeValue : 0;

                // Total section
                string[] footerLabels = { "SUBTOTAL:", "AMOUNT PAID:", "CHANGE:" };
                string[] footerValues = {
            "₱" + totalPrice.ToString("F2"),
            "₱" + amountValue.ToString("F2"),
            "₱" + changeValue.ToString("F2")
        };

                for (int i = 0; i < footerLabels.Length; i++)
                {
                    Font currentFont = (i == footerLabels.Length - 1) ? boldFont : regularFont;

                    e.Graphics.DrawString(footerLabels[i], currentFont, Brushes.Black,
                        leftMargin + pageWidth * 0.6f, yPos);
                    e.Graphics.DrawString(footerValues[i], currentFont, Brushes.Black,
                        leftMargin + pageWidth, yPos, rightFormat);
                    yPos += lineHeight + 3;
                }

                // Thank you message
                yPos += 15;
                e.Graphics.DrawString("Thank you for your purchase!", boldFont, Brushes.Black,
                    leftMargin + (pageWidth / 2), yPos, centerFormat);
                yPos += lineHeight + 5;

                e.Graphics.DrawString("Please keep this receipt for your records.", footerFont, Brushes.Black,
                    leftMargin + (pageWidth / 2), yPos, centerFormat);
            }

            // Dispose fonts
            headerFont.Dispose();
            subHeaderFont.Dispose();
            regularFont.Dispose();
            boldFont.Dispose();
            footerFont.Dispose();
            centerFormat.Dispose();
            rightFormat.Dispose();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CashierOrders_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}