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
    internal class CategoriesData
    {
        public int ID { get; set; }
        public string Category { get; set; }
        public string Date { get; set; }

        public List<CategoriesData> AllCategoriesData()
        {
            // Prevent execution in Design mode
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return new List<CategoriesData>();

            List<CategoriesData> listData = new List<CategoriesData>();

            using (SqlConnection connect = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString))
            {
                connect.Open();
                string selectData = "SELECT * FROM categories";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        CategoriesData cData = new CategoriesData
                        {
                            ID = (int)reader["id"],
                            Category = reader["category"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        listData.Add(cData);
                    }
                }
            }

            return listData;
        }
    }
}
