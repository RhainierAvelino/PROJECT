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

namespace Smart_Stock_Project
{
    public partial class AdminAddUsers : UserControl
    {


        SqlConnection connect;

        public AdminAddUsers()
        {
            InitializeComponent();

            if (!IsInDesignMode())
            {
                connect = new SqlConnection(ConfigurationManager.ConnectionStrings["Smart_Stock_Project.Properties.Settings.SmartStockInventoryConnectionString"].ConnectionString);
            }

            this.Load += new System.EventHandler(this.AdminAddUsers_Load);
        }
        private bool IsInDesignMode()
        {
            return LicenseManager.UsageMode == LicenseUsageMode.Designtime
                   || DesignMode
                   || System.Diagnostics.Process.GetCurrentProcess().ProcessName == "devenv";
        }
public bool checkConnection()
{
    if (connect == null || connect.State != ConnectionState.Closed)
        return false;

    return true;
}

        public void displayAllUsersData()
        {
            if (this.DesignMode || LicenseManager.UsageMode == LicenseUsageMode.Designtime)
                return;

            if (dataGridView1 == null)
                return;

            UsersData uData = new UsersData();
            List<UsersData> listData = uData.AllUsersData();
            dataGridView1.DataSource = listData;
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            if (!this.DesignMode && dataGridView1 != null)
            {
                displayAllUsersData();
            }
        }




        private void AdminAddUsers_Load(object sender, EventArgs e)
        {
            if (!IsInRuntimeMode()) return; // ← skip if in design mode

            if (dataGridView1 != null)
            {
                displayAllUsersData();
            }
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayAllUsersData();

        }

        private bool IsInRuntimeMode()
        {
            return !(LicenseManager.UsageMode == LicenseUsageMode.Designtime || DesignMode);
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_user_button_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_password.Text == ""  || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            cmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(addUsers_username.Text.Trim() + " is already taken", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password_hash, role, status, date) " +
                                    "VALUES(@username, @password_hash, @role, @status, @date)";




                                using (SqlCommand insertD = new SqlCommand(insertData, connect))
                                {

                                    insertD.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                                    insertD.Parameters.AddWithValue("@password_hash", HashPassword(addUsers_password.Text.Trim()));
                                    insertD.Parameters.AddWithValue("@role", addUsers_role.SelectedItem.ToString());
                                    insertD.Parameters.AddWithValue("@status", addUsers_status.SelectedItem.ToString());


                                    DateTime today = DateTime.Today;
                                    insertD.Parameters.AddWithValue("@date", today);

                                    insertD.ExecuteNonQuery();

                                    clearFields();

                                    MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayAllUsersData();

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

            //For Password Hashing
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


        public void clearFields()
        {
            addUsers_username.Clear();
            addUsers_password.Clear();
            addUsers_role.SelectedIndex = -1;
            addUsers_status.SelectedIndex = -1;
        }
        private void clear_user_button_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void update_user_button_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" || addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Update User ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();

                           
                                    string updateData = "UPDATE users SET username = @username, password_hash = @password_hash, role = @role, status = @status WHERE id = @id";

                                    using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                                    {
                                        updateCmd.Parameters.AddWithValue("@username", addUsers_username.Text.Trim());
                                        updateCmd.Parameters.AddWithValue("@password_hash", HashPassword(addUsers_password.Text.Trim()));
                                        updateCmd.Parameters.AddWithValue("@role", addUsers_role.SelectedItem);
                                        updateCmd.Parameters.AddWithValue("@status", addUsers_status.SelectedItem);
                                        updateCmd.Parameters.AddWithValue("@id", getID);

                                        updateCmd.ExecuteNonQuery();
                                        clearFields();

                                        MessageBox.Show("Updated successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        displayAllUsersData();
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

        private int getID = 0;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                string username = row.Cells[1].Value.ToString();
                string password_hash = row.Cells[2].Value.ToString();
                string role = row.Cells[3].Value.ToString();
                string status = row.Cells[4].Value.ToString();

                addUsers_username.Text = username;
                addUsers_password.Text = "";
                addUsers_role.Text = role;
                addUsers_status.Text = status;


            }
        }

        private void remove_user_button_Click(object sender, EventArgs e)
        {
            if (addUsers_username.Text == "" ||  addUsers_role.SelectedIndex == -1 || addUsers_status.SelectedIndex == -1)
            {
                MessageBox.Show("Empty Fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove User ID: " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (checkConnection())
                    {
                        try
                        {
                            connect.Open();


                            string updateData = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand updateCmd = new SqlCommand(updateData, connect))
                            {
                                updateCmd.Parameters.AddWithValue("@id", getID);

                                updateCmd.ExecuteNonQuery();
                                clearFields();

                                MessageBox.Show("Removed successfully!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayAllUsersData();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminAddUsers_Load_1(object sender, EventArgs e)
        {

        }
    }
}
