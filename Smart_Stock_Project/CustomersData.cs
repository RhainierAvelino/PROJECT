using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Smart_Stock_Project
{
    internal class CustomersData
    {
        private readonly string connStr;
        private readonly SqlConnection connect;

        public CustomersData()
        {
            connStr = ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"]?.ConnectionString;
            if (string.IsNullOrEmpty(connStr))
                throw new InvalidOperationException("Missing connection string: Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString");

            connect = new SqlConnection(connStr);
        }

        public string CustomerID { set; get; }
        public string TotalPrice { set; get; }
        public string Amount { set; get; }
        public string ChangeAmount { set; get; }
        public string OrderDate { set; get; }

        public List<CustomersData> AllCustomersData()
        {
            // Prevent execution in Design mode
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return new List<CustomersData>();
            List<CustomersData> listData = new List<CustomersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM customers";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomersData cData = new CustomersData();

                            cData.CustomerID = reader["customer_id"].ToString();
                            cData.TotalPrice = reader["total_price"].ToString();
                            cData.Amount = reader["amount"].ToString();
                            cData.ChangeAmount = reader["change_amount"].ToString();
                            cData.OrderDate = reader["order_date"].ToString();

                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }

        public List<CustomersData> AllTodaysCustomersData()
        {
            // Prevent execution in Design mode
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return new List<CustomersData>();
            List<CustomersData> listData = new List<CustomersData>();
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    DateTime today = DateTime.Today;
                    string selectData = "SELECT * FROM customers WHERE order_date = @order_date";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@order_date", today.ToString("yyyy-MM-dd")); // Adjust date format as needed
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CustomersData cData = new CustomersData();

                            cData.CustomerID = reader["customer_id"].ToString();
                            cData.TotalPrice = reader["total_price"].ToString();
                            cData.Amount = reader["amount"].ToString();
                            cData.ChangeAmount = reader["change_amount"].ToString();
                            cData.OrderDate = reader["order_date"].ToString();

                            listData.Add(cData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error connecting to database: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }

            return listData;
        }
    }
}
