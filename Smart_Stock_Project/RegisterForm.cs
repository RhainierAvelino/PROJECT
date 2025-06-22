using SmartStock_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient; // Ensure you have the correct using directive for SQL Server operations
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Smart_Stock_Project
{
    public partial class RegisterForm : Form
    {
        SqlConnection
            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString); 
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_up_link_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();

            this.Hide();
        }

        private void no_account_label_Click(object sender, EventArgs e)
        {

        }

        private void login_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void username_label_Click(object sender, EventArgs e)
        {

        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
           if (register_username.Text == "" || register_password.Text == "" || register_cPassword.Text == "")
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string checkUsername = "SELECT * FROM users WHERE  username = @username";

                        using(SqlCommand cmd = new SqlCommand(checkUsername, connect))
                        {
                            cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if(table.Rows.Count > 0)
                            {
                                MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(register_password.Text.Length < 8)
                            {
                                MessageBox.Show("Invalid Password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(register_password.Text.Trim() != register_cPassword.Text.Trim())
                            {
                                MessageBox.Show("Passwords do not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password_hash, role, status, date) " +
                                    "VALUES(@username, @password_hash, @role, @status, @date)";

                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {
                                    insertD.Parameters.AddWithValue("@username", register_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password_hash", HashPassword(register_password.Text.Trim()));
                                    insertD.Parameters.AddWithValue("@role", "Cashier");
                                    insertD.Parameters.AddWithValue("@status", "Approval");
                                    insertD.Parameters.AddWithValue("@date", DateTime.Today);
                                    
                                    insertD.ExecuteNonQuery();

                                    MessageBox.Show("Registered Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginForm = new LoginForm();
                                    loginForm.Show();

                                    this.Hide();



                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        public bool checkConnection()
        {
            if(connect.State == ConnectionState.Closed)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }
        private string HashPassword(string password)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }


        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPass.Checked ? '\0' : '*';
            register_cPassword.PasswordChar = register_showPass.Checked ? '\0' : '*';
        }
    }
}
