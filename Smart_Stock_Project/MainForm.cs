using SmartStock_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Stock_Project
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            //  Lock the size and scaling
            this.Size = new Size(1304, 794); 
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.AutoScaleMode = AutoScaleMode.None;
        }

        private void register_label_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = true;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;

            AdminAddUsers aaForm = adminAddUsers1 as AdminAddUsers;
            if (aaForm != null)
            {
                aaForm.refreshData();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = true;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;

            CashierCustomersForm ccForm = cashierCustomersForm1 as CashierCustomersForm;
            if (ccForm != null)
            {
                ccForm.refreshData();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminAddUsers1_Load(object sender, EventArgs e)
        {

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void adminAddUsers1_Load_1(object sender, EventArgs e)
        {

        }

        private void adminAddCategories1_Load(object sender, EventArgs e)
        {

        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void adminAddProducts1_Load_1(object sender, EventArgs e)
        {

        }

        private void adminAddProducts1_Load_2(object sender, EventArgs e)
        {

        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {

            if (adminDashboard1 != null)
                adminDashboard1.Visible = true;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;

            AdminDashboard adForm = adminDashboard1 as AdminDashboard;

            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = true;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;

            AdminAddCategories aacForm = adminAddCategories1 as AdminAddCategories;
            if (aacForm != null)
            {
                aacForm.refreshData();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = true;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;
            if (aapForm != null)
            {
                aapForm.refreshData();
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = true;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;

        }

        private void adminDashboard1_Load(object sender, EventArgs e)
        {

        }

        private void adminDashboard1_Load_1(object sender, EventArgs e)
        {

        }

        private void salesForecasting1_Load(object sender, EventArgs e)
        {

        }

        private void sales_forecasting_button_Click(object sender, EventArgs e)
        {
            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = true;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = false;
        }

        private void csvbutton_Click(object sender, EventArgs e)
        {
            if (adminDashboard1 != null)
                adminDashboard1.Visible = false;
            if (adminAddUsers1 != null)
                adminAddUsers1.Visible = false;
            if (adminAddCategories1 != null)
                adminAddCategories1.Visible = false;
            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;
            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;
            if (aprioriAnalysis1 != null)
                aprioriAnalysis1.Visible = false;
            if (salesForecasting1 != null)
                salesForecasting1.Visible = false;
            if (csvDataSeeder1 != null)
                csvDataSeeder1.Visible = true;

        }
    }
}
