using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Smart_Stock_Project
{
    public partial class AdminAddProducts : UserControl
    {
        SqlConnection connect;
        public AdminAddProducts()
        {
            InitializeComponent();


            if (!IsInDesignMode())
            {
                connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString);

                displayCategories();
                displayProductsData();
            }

            this.Load += new System.EventHandler(this.AdminAddProducts_Load);
        }
        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                   || DesignMode
                   || System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
        }

        public bool CheckConnection()
        {
            if (connect == null || connect.State != ConnectionState.Closed)
                return false;

            return true;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (!this.DesignMode && dataGridView1 != null)
            {
                // displayProductsData();
            }
        }

        public void displayProductsData()
        {
            ProductsData apData = new ProductsData();
            List<ProductsData> listData = apData.AllProductsData();

            dataGridView1.DataSource = listData;
        }

        private void AdminAddProducts_Load(object sender, EventArgs e)
        {
            if (!IsInDesignMode())
            {
                // displayProductsData();
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) //import button
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";
                string imagepath = "";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagepath = dialog.FileName;
                    add_product_image.ImageLocation = imagepath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Messaege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public bool emptyFields()
        {
            if (add_productID.Text == "" || add_product_name.Text == "" ||
                add_product_category.SelectedIndex == -1 || add_product_price.Text == "" ||
                add_product_stock.Text == "" || add_product_image.Image == null ||
                add_product_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void displayCategories()
        {
            if (CheckConnection())
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM categories";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                add_product_category.Items.Add(reader["category"].ToString());
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

        private void add_product_button_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        if (connect.State != ConnectionState.Open)
                        {
                            connect.Open();
                        }

                        string selectData = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                            cmd.Parameters.AddWithValue("@prodID", add_productID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID: " + add_productID.Text.Trim() + " is existing already"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {

                                string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                                string relativePath = Path.Combine("Product_Directory", add_productID.Text.Trim() + ".jpg");
                                string path = Path.Combine(baseDirectory, relativePath);

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(add_product_image.ImageLocation, path, true);

                                string insertData = "INSERT INTO products" +
                                    "(prod_id, prod_name, category, price, stock, image_path, status, date_insert)" +
                                    "VALUES (@prodID, @prodName, @cat, @price,@stock, @path, @status, @date)";
                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@prodID", add_productID.Text.Trim());
                                    insertD.Parameters.AddWithValue("@prodName", add_product_name.Text.Trim());
                                    insertD.Parameters.AddWithValue("@cat", add_product_category.SelectedItem);
                                    insertD.Parameters.AddWithValue("@price", add_product_price.Text.Trim());
                                    insertD.Parameters.AddWithValue("@stock", add_product_stock.Text.Trim());
                                    insertD.Parameters.AddWithValue("@path", path);
                                    insertD.Parameters.AddWithValue("@status", add_product_status.SelectedItem);

                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayProductsData();

                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                    }
                }
            }



        }

        public bool checkConnection()
        {
            if (connect.State != ConnectionState.Open)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void update_product_button_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update this product ID: "
                    + add_productID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            if (connect.State != ConnectionState.Open)
                            {
                                connect.Open();
                            }

                            string updateData = "UPDATE products SET prod_id = @prodID, prod_name = @prodName," +
                                " category = @cat, price = @price, stock = @stock, status = @status WHERE id = @id";
                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@prodID", add_productID.Text.Trim());
                                updateD.Parameters.AddWithValue("@prodName", add_product_name.Text.Trim());
                                updateD.Parameters.AddWithValue("@cat", add_product_category.SelectedItem);
                                updateD.Parameters.AddWithValue("@price", add_product_price.Text.Trim());
                                updateD.Parameters.AddWithValue("@stock", add_product_stock.Text.Trim());
                                updateD.Parameters.AddWithValue("@status", add_product_status.SelectedItem);
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayProductsData();

                                MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
        }

        public void clearFields()
        {
            add_productID.Text = "";
            add_product_name.Text = "";
            add_product_category.SelectedIndex = -1;
            add_product_price.Text = "";
            add_product_stock.Text = "";
            add_product_status.SelectedIndex = -1;
            add_product_image.Image = null;
        }
        private void clear_product_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;

                add_productID.Text = row.Cells[1].Value.ToString();
                add_product_name.Text = row.Cells[2].Value.ToString();
                add_product_category.Text = row.Cells[3].Value.ToString();
                add_product_price.Text = row.Cells[4].Value.ToString();
                add_product_stock.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value.ToString();

                try
                {
                    if (imagePath != null)
                    {
                        add_product_image.Image = Image.FromFile(imagePath);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex, "ErrorMessage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                add_product_status.SelectedItem = row.Cells[7].Value.ToString();



            }
        }

        private void remove_product_button_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this product ID: "
                    + add_productID.Text.Trim() + "?", "Confirmation Message"
                    , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            if (connect.State != ConnectionState.Open)
                            {
                                connect.Open();
                            }

                            string deleteData = "DELETE FROM products WHERE id = @id";
                            using (SqlCommand delD = new SqlCommand(deleteData, connect))
                            {
                                delD.Parameters.AddWithValue("@id", getID);

                                delD.ExecuteNonQuery();
                                clearFields();
                                displayProductsData();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);


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
        }
    }
}
