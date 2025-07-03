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
using System.Text.RegularExpressions;

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
                // validation for whitespace-only inputs
                if (string.IsNullOrWhiteSpace(register_username.Text) ||
                    string.IsNullOrWhiteSpace(register_password.Text) ||
                    string.IsNullOrWhiteSpace(register_cPassword.Text))
                {
                    MessageBox.Show("Fields cannot contain only whitespace.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Username length validation
                else if (register_username.Text.Trim().Length < 3)
                {
                    MessageBox.Show("Username must be at least 3 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Username length maximum validation
                else if (register_username.Text.Trim().Length > 50)
                {
                    MessageBox.Show("Username cannot exceed 50 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Username format validation (alphanumeric and underscore only)
                else if (!IsValidUsername(register_username.Text.Trim()))
                {
                    MessageBox.Show("Username can only contain letters, numbers, and underscores.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Password maximum length validation
                else if (register_password.Text.Length > 128)
                {
                    MessageBox.Show("Password cannot exceed 128 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Password strength validation
                else if (!IsStrongPassword(register_password.Text))
                {
                    MessageBox.Show("Password must contain at least one uppercase letter, one lowercase letter, one number, and one special character.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Password common patterns validation
                else if (ContainsCommonPatterns(register_password.Text))
                {
                    MessageBox.Show("Password contains common patterns. Please choose a more secure password.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                            string checkUsername = "SELECT * FROM users WHERE  username = @username";

                            using (SqlCommand cmd = new SqlCommand(checkUsername, connect))
                            {
                                cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());

                                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                                DataTable table = new DataTable();
                                adapter.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    MessageBox.Show(register_username.Text.Trim() + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (register_password.Text.Length < 8)
                                {
                                    MessageBox.Show("Invalid Password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                else if (register_password.Text.Trim() != register_cPassword.Text.Trim())
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
        }

        public bool checkConnection()
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

        // NEW VALIDATION METHODS - Added without changing existing code

        /// Validates username format (alphanumeric and underscore only)
        private bool IsValidUsername(string username)
        {
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$");
        }

        /// Validates password strength (at least one uppercase, lowercase, number, and special character)
        private bool IsStrongPassword(string password)
        {
            bool hasUpper = password.Any(char.IsUpper);
            bool hasLower = password.Any(char.IsLower);
            bool hasDigit = password.Any(char.IsDigit);
            bool hasSpecial = password.Any(c => !char.IsLetterOrDigit(c));

            return hasUpper && hasLower && hasDigit && hasSpecial;
        }

        /// Checks for common password patterns that should be avoided
        private bool ContainsCommonPatterns(string password)
        {
            string lowerPassword = password.ToLower();

            // Common weak patterns
            string[] commonPatterns = {
                "123456", "password", "admin", "qwerty", "abc123",
                "111111", "welcome", "login", "master", "root",
                "user", "guest", "test", "demo", "default"
            };

            // Check if password contains any common patterns
            foreach (string pattern in commonPatterns)
            {
                if (lowerPassword.Contains(pattern))
                {
                    return true;
                }
            }

            // Check for sequential characters (like "123" or "abc")
            if (ContainsSequentialChars(lowerPassword))
            {
                return true;
            }

            // Check for repeated characters (like "aaa" or "111")
            if (ContainsRepeatedChars(password))
            {
                return true;
            }

            return false;
        }

        /// Checks for sequential characters in password
        private bool ContainsSequentialChars(string password)
        {
            for (int i = 0; i < password.Length - 2; i++)
            {
                if (password[i] + 1 == password[i + 1] && password[i + 1] + 1 == password[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        /// Checks for repeated characters in password (3 or more consecutive)
        private bool ContainsRepeatedChars(string password)
        {
            for (int i = 0; i < password.Length - 2; i++)
            {
                if (password[i] == password[i + 1] && password[i + 1] == password[i + 2])
                {
                    return true;
                }
            }
            return false;
        }

        /// Real-time username validation 
        private bool ValidateUsernameRealTime(string username)
        {
            if (string.IsNullOrWhiteSpace(username))
                return false;

            if (username.Length < 3 || username.Length > 50)
                return false;

            return IsValidUsername(username);
        }

        /// Real-time password validation 
        private bool ValidatePasswordRealTime(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            if (password.Length < 8 || password.Length > 128)
                return false;

            return IsStrongPassword(password);
        }

        /// Sanitizes input by removing potentially harmful characters
        private string SanitizeInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            // Remove potential SQL injection characters and trim
            return input.Trim()
                       .Replace("'", "")
                       .Replace("\"", "")
                       .Replace(";", "")
                       .Replace("--", "")
                       .Replace("/*", "")
                       .Replace("*/", "")
                       .Replace("xp_", "")
                       .Replace("sp_", "");
        }
    }
}