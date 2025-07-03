using Smart_Stock_Project;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.RegularExpressions;

namespace SmartStock_System
{
    public partial class LoginForm : Form
    {
        SqlConnection
            connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString);

        // Login attempt tracking
        private static Dictionary<string, int> loginAttempts = new Dictionary<string, int>();
        private static Dictionary<string, DateTime> lastAttemptTime = new Dictionary<string, DateTime>();
        private const int MAX_LOGIN_ATTEMPTS = 5;
        private const int LOCKOUT_MINUTES = 15;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sign_up_link_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();

            this.Hide();
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

        private void login_button_Click(object sender, EventArgs e)
        {
            // Input validation - Added validations without changing existing logic
            if (string.IsNullOrEmpty(login_username.Text) || string.IsNullOrEmpty(login_password.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Whitespace validation
            if (string.IsNullOrWhiteSpace(login_username.Text) || string.IsNullOrWhiteSpace(login_password.Text))
            {
                MessageBox.Show("Username and password cannot be empty or contain only whitespace.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Input length validation
            if (login_username.Text.Trim().Length < 3)
            {
                MessageBox.Show("Username must be at least 3 characters long.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login_username.Text.Trim().Length > 50)
            {
                MessageBox.Show("Username cannot exceed 50 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (login_password.Text.Length > 128)
            {
                MessageBox.Show("Password cannot exceed 128 characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Username format validation (allow your admin username "nhier" to pass)
            if (!IsValidUsernameFormat(login_username.Text.Trim()))
            {
                MessageBox.Show("Username contains invalid characters.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Rate limiting check
            string userKey = login_username.Text.Trim().ToLower();
            if (IsAccountLocked(userKey))
            {
                MessageBox.Show($"Account temporarily locked due to too many failed attempts. Please try again after {LOCKOUT_MINUTES} minutes.", "Account Locked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Proceed with original login logic
            if (checkConnection())
            {
                try
                {
                    connect.Open();

                    string selecData = "SELECT COUNT(*) FROM users WHERE  username = @username AND password_hash = @password_hash AND status = @status";

                    using (SqlCommand cmd = new SqlCommand(selecData, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", login_username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password_hash", HashPassword(login_password.Text.Trim()));
                        cmd.Parameters.AddWithValue("@status", "Active");

                        int rowCount = (int)cmd.ExecuteScalar();

                        if (rowCount > 0)
                        {
                            // Reset login attempts on successful login
                            ResetLoginAttempts(userKey);

                            string selectRole = "SELECT role FROM users WHERE username = @username AND password_hash = @password_hash AND status = @status";

                            using (SqlCommand getRole = new SqlCommand(selectRole, connect))
                            {
                                getRole.Parameters.AddWithValue("@username", login_username.Text.Trim());
                                getRole.Parameters.AddWithValue("@password_hash", HashPassword(login_password.Text.Trim()));
                                getRole.Parameters.AddWithValue("@status", "Active");
                                string userRole = (string)getRole.ExecuteScalar();

                                if (userRole == "Admin")
                                {
                                    MessageBox.Show("Login Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    MainForm mForm = new MainForm();
                                    mForm.Show();

                                    this.Hide();
                                }
                                else if (userRole == "Cashier")
                                {
                                    MessageBox.Show("Login Succesfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    CasherMainForm cForm = new CasherMainForm();
                                    cForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                        else
                        {
                            // Increment failed login attempts
                            IncrementLoginAttempts(userKey);



                            MessageBox.Show("Incorrect Username/Password or not yet Approved", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // Clear password field for security
                            login_password.Clear();
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Initialize form with focus on username field
            login_username.Focus();
        }


        /// Validates username format (allows your admin username "nhier" to pass)
        private bool IsValidUsernameFormat(string username)
        {
            // Allow alphanumeric characters and underscore
            // This will allow your "nhier" username to pass
            return Regex.IsMatch(username, @"^[a-zA-Z0-9_]+$");
        }

        /// Checks for potential SQL injection attempts
        private bool ContainsSqlInjectionAttempt(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            string lowerInput = input.ToLower();

            // Common SQL injection patterns
            string[] sqlPatterns = {
                "'", "\"", ";", "--", "/*", "*/", "xp_", "sp_",
                "exec", "execute", "select", "insert", "update",
                "delete", "drop", "create", "alter", "union",
                "script", "javascript", "vbscript", "onload",
                "onerror", "onclick", "<", ">", "eval"
            };

            return sqlPatterns.Any(pattern => lowerInput.Contains(pattern));
        }

        /// Checks if account is locked due to too many failed attempts
        private bool IsAccountLocked(string userKey)
        {
            if (!loginAttempts.ContainsKey(userKey))
                return false;

            if (loginAttempts[userKey] >= MAX_LOGIN_ATTEMPTS)
            {
                if (lastAttemptTime.ContainsKey(userKey))
                {
                    TimeSpan timeSinceLastAttempt = DateTime.Now - lastAttemptTime[userKey];
                    if (timeSinceLastAttempt.TotalMinutes < LOCKOUT_MINUTES)
                    {
                        return true;
                    }
                    else
                    {
                        // Reset attempts after lockout period
                        ResetLoginAttempts(userKey);
                        return false;
                    }
                }
            }

            return false;
        }

        /// Increments failed login attempts for a user
        private void IncrementLoginAttempts(string userKey)
        {
            if (!loginAttempts.ContainsKey(userKey))
            {
                loginAttempts[userKey] = 0;
            }

            loginAttempts[userKey]++;
            lastAttemptTime[userKey] = DateTime.Now;

            // Show warning if approaching lockout
            if (loginAttempts[userKey] >= MAX_LOGIN_ATTEMPTS - 1)
            {
                MessageBox.Show($"Warning: Account will be locked after {MAX_LOGIN_ATTEMPTS - loginAttempts[userKey]} more failed attempt(s).",
                    "Login Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// Resets login attempts for a user
        private void ResetLoginAttempts(string userKey)
        {
            if (loginAttempts.ContainsKey(userKey))
            {
                loginAttempts.Remove(userKey);
            }
            if (lastAttemptTime.ContainsKey(userKey))
            {
                lastAttemptTime.Remove(userKey);
            }
        }


        /// Sanitizes input to prevent basic injection attempts
        private string SanitizeInput(string input)
        {
            if (string.IsNullOrEmpty(input))
                return string.Empty;

            return input.Trim()
                       .Replace("'", "")
                       .Replace("\"", "")
                       .Replace(";", "")
                       .Replace("--", "")
                       .Replace("/*", "")
                       .Replace("*/", "");
        }

        /// Validates input length constraints
        private bool IsValidInputLength(string input, int minLength, int maxLength)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            return input.Length >= minLength && input.Length <= maxLength;
        }

        /// Checks if input contains only safe characters
        private bool ContainsOnlySafeCharacters(string input)
        {
            if (string.IsNullOrEmpty(input))
                return false;

            // Allow letters, numbers, underscore, and basic punctuation
            return Regex.IsMatch(input, @"^[a-zA-Z0-9_\-\.@]+$");
        }

        /// Real-time validation for login form 
        private void ValidateLoginInputs()
        {
            bool isUsernameValid = !string.IsNullOrWhiteSpace(login_username.Text) &&
                                  IsValidInputLength(login_username.Text.Trim(), 3, 50) &&
                                  IsValidUsernameFormat(login_username.Text.Trim());

            bool isPasswordValid = !string.IsNullOrWhiteSpace(login_password.Text) &&
                                  IsValidInputLength(login_password.Text, 1, 128);

        }
    }
}