using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Smart_Stock_Project
{
    public partial class AdminAddCategories : UserControl
    {
        SqlConnection connect;

        public AdminAddCategories()
        {
            InitializeComponent();

            if (!IsInDesignMode())
            {
                connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString);
            }

            this.Load += new System.EventHandler(this.AdminAddCategories_Load);
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
                displayCategoriesData();
            }
        }

        private void add_username_label_Click(object sender, EventArgs e)
        {

        }

        public void displayCategoriesData()
        {
            CategoriesData cData = new CategoriesData();
            List<CategoriesData> listData = cData.AllCategoriesData();

            dataGridView1.DataSource = listData;
        }

        private void add_category_button_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (CheckConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkCat = "SELECT * FROM categories WHERE category = @cat";

                        using (SqlCommand cmd = new SqlCommand(checkCat, connect))
                        {
                            cmd.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Category: " + addCategories_category.Text.Trim() + "is already exist"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO categories (category, date) VALUES(@cat, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();
                                    clearFields();
                                    displayCategoriesData();

                                    MessageBox.Show("Added Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void AdminAddCategories_Load(object sender, EventArgs e)
        {
            if (!IsInDesignMode())
            {
                displayCategoriesData();
            }
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        public void clearFields()
        {
            addCategories_category.Text = "";
        }
        private void clear_category_button_Click(object sender, EventArgs e)
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

                addCategories_category.Text = row.Cells[1].Value.ToString();
            }
        }

        private void update_category_button_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update Cat ID: " + getID
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();

                            string updateData = "UPDATE categories SET category = @cat WHERE id = @id";

                            using (SqlCommand updateD = new SqlCommand(updateData, connect))
                            {
                                updateD.Parameters.AddWithValue("@cat", addCategories_category.Text.Trim());
                                updateD.Parameters.AddWithValue("@id", getID);

                                updateD.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();

                                MessageBox.Show("Updated Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        private void remove_category_button_Click(object sender, EventArgs e)
        {
            if (addCategories_category.Text == "")
            {
                MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove Cat ID: " + getID
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (CheckConnection())
                    {
                        try
                        {
                            connect.Open();

                            string removeData = "DELETE FROM categories WHERE id = @id";

                            using (SqlCommand deleteD = new SqlCommand(removeData, connect))
                            {
                                deleteD.Parameters.AddWithValue("@id", getID);

                                deleteD.ExecuteNonQuery();
                                clearFields();
                                displayCategoriesData();

                                MessageBox.Show("Removed Successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection Failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
