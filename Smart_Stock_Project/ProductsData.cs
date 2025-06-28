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
    class ProductsData
    {
        public int ID { set; get; }
        public string ProdID { set; get; }
        public string ProdName { set; get; }
        public string Category { set; get; }
        public string Price { set; get; }
        public string Stock { set; get; }
        public string ImagePath { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }

        public List<ProductsData> AllProductsData()
        {
            // Prevent execution in Design mode
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return new List<ProductsData>();

            List<ProductsData> listData = new List<ProductsData>();

            using (SqlConnection connect = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString))
            {
                connect.Open();
                string selectData = "SELECT * FROM products";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductsData apData = new ProductsData();

                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();


                        listData.Add(apData);
                    }
                }
            }

            return listData;
        }

        public List<ProductsData> allAvailableProductsData()
        {
            // Prevent execution in Design mode
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return new List<ProductsData>();
            List<ProductsData> listData = new List<ProductsData>();
            using (SqlConnection connect = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString))
            {
                connect.Open();
                string selectData = "SELECT * FROM products WHERE status = 'Available'";
                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ProductsData apData = new ProductsData();

                        apData.ID = (int)reader["id"];
                        apData.ProdID = reader["prod_id"].ToString();
                        apData.ProdName = reader["prod_name"].ToString();
                        apData.Category = reader["category"].ToString();
                        apData.Price = reader["price"].ToString();
                        apData.Stock = reader["stock"].ToString();
                        apData.ImagePath = reader["image_path"].ToString();
                        apData.Status = reader["status"].ToString();
                        apData.Date = reader["date_insert"].ToString();

                        listData.Add(apData);
                    }
                }
            }
            return listData;




        }
    }
}
