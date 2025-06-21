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
    class UsersData
    {      
        public int ID { set; get; }
        public string Username { set; get; }
        public string Password_hash { set; get; }
        public string Role { set; get; }
        public string Status { set; get; }
        public string Date { set; get; }
        public List<UsersData> AllUsersData()
        {
            // Prevent execution in Design mode
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return new List<UsersData>();

            List<UsersData> listData = new List<UsersData>();

            using (SqlConnection connect = new SqlConnection(
                ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString))
            {
                connect.Open();
                string selectData = "SELECT * FROM users";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UsersData uData = new UsersData
                        {
                            ID = (int)reader["id"],
                            Username = reader["username"].ToString(),
                            Password_hash = reader["password_hash"].ToString(),
                            Role = reader["role"].ToString(),
                            Status = reader["status"].ToString(),
                            Date = reader["date"].ToString()
                        };

                        listData.Add(uData);
                    }
                }
            }

            return listData;
        }



    }
}
