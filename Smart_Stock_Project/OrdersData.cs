using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Smart_Stock_Project
{
    internal class OrdersData
    {
        SqlConnection connect = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString);

        public int ID { set; get; }
        public string CustomerID { set; get; }
        public string ProductID { set; get; }
        public string ProductName { set; get; }
        public string Category { set; get; }
        public string OrigPrice { set; get; }
        public string Quantity { set; get; }
        public string TotalPrice { set; get; }
        public string OrderDate { set; get; }

        public List<OrdersData> AllOrdersData()
        {
            List<OrdersData> listData = new List<OrdersData>();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM orders"; // ← No WHERE clause here

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            OrdersData oData = new OrdersData();
                            oData.ID = (int) reader["id"];
                            oData.CustomerID = reader["customer_id"].ToString();
                            oData.ProductID = reader["prod_id"].ToString();
                            oData.ProductName = reader["prod_name"].ToString();
                            oData.Category = reader["category"].ToString();
                            oData.OrigPrice = reader["orig_price"].ToString();
                            oData.Quantity = reader["quantity"].ToString();
                            oData.TotalPrice = reader["total_price"].ToString();
                            oData.OrderDate = reader["order_date"].ToString();

                            listData.Add(oData);
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
