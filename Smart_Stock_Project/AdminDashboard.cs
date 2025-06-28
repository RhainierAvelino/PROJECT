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
using System.Globalization;

namespace Smart_Stock_Project
{
    public partial class AdminDashboard : UserControl
    {
        private SqlConnection connect;

        public AdminDashboard()
        {
            InitializeComponent();

            if (!IsInDesignMode())
            {
                string connStr = ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"]?.ConnectionString;
                if (!string.IsNullOrEmpty(connStr))
                {
                    connect = new SqlConnection(connStr);
                }

                this.Load += AdminDashboard_Load;
            }
        }


        public void displayTodaysCustomer()
        {
            CustomersData cData = new CustomersData();
            List<CustomersData> listData = cData.AllTodaysCustomersData();
            dataGridView1.DataSource = listData;
        }

        public void displayTodaysIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = " SELECT SUM (total_price) FROM customers WHERE order_date = @order_date";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        DateTime today = DateTime.Today;

                        cmd.Parameters.AddWithValue("@order_date", today.ToString("yyyy-MM-dd"));
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            object value = reader[0];
                            if (value != DBNull.Value)
                            {
                                decimal totalIncome = Convert.ToDecimal(value);
                                dashboard_today_income.Text = totalIncome.ToString("C2", new CultureInfo("en-PH"));
                            }
                            else
                            {
                                dashboard_today_income.Text = "0.00"; // Default value if no income
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayTotalIncome()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = " SELECT SUM (total_price) FROM customers";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            object value = reader[0];
                            if (value != DBNull.Value)
                            {
                                decimal totalIncome = Convert.ToDecimal(value);
                                dashboard_total_income.Text = totalIncome.ToString("C2", new CultureInfo("en-PH"));
                            }
                            else
                            {
                                dashboard_total_income.Text = "0.00"; // Default value if no income
                            }
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public bool checkConnection()
        {
            if (connect == null)
            {
                MessageBox.Show("Connection is not initialized.", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return connect.State == ConnectionState.Closed;
        }

        public void displayAllUsers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = " SELECT COUNT (id) FROM users WHERE status = @status";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@status", "Active");

                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_all_user.Text = count.ToString();
                        }
                        reader.Close();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
        }

        public void displayAllCustomers()
        {
            if (checkConnection())
            {
                try
                {
                    connect.Open();
                    string selectData = " SELECT COUNT (id) FROM customers";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {
                            int count = Convert.ToInt32(reader[0]);
                            dashboard_all_customer.Text = count.ToString();
                        }
                        reader.Close();
 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
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
            displayTodaysCustomer();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            if (IsInDesignMode()) return; 
            displayTodaysCustomer();
            displayAllUsers();
            displayAllCustomers();
            displayTodaysIncome();
            displayTotalIncome();
        }

        private void dashboard_all_user_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_all_customer_Click(object sender, EventArgs e)
        {

        }

        private static bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                || System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
        }

        private void dashboard_today_income_Click(object sender, EventArgs e)
        {

        }
    }
}
