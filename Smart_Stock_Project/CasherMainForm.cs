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
    public partial class CasherMainForm : Form
    {
        public CasherMainForm()
        {
            InitializeComponent();
        }

        private void CasherMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (adminDashboard2 != null)
                adminDashboard2.Visible = false;

            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;

            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = true;

            if (cashierOrders1 != null)
                cashierOrders1.Visible = false;

            CashierCustomersForm ccfForm = cashierCustomersForm1 as CashierCustomersForm;
            if (ccfForm != null)
            {
                ccfForm.refreshData();
            }

        }

        private void logout_button_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cashierOrders1_Load(object sender, EventArgs e)
        {

        }

        private void adminAddProducts1_Load(object sender, EventArgs e)
        {

        }

        private void dashboard_button_Click(object sender, EventArgs e)
        {
            if (adminDashboard2 != null)
                adminDashboard2.Visible = true;

            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;

            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;

            if (cashierOrders1 != null)
                cashierOrders1.Visible = false;

            AdminDashboard adForm = adminDashboard2 as AdminDashboard;
            if (adForm != null)
            {
                adForm.refreshData();
            }
        }

        private void add_products_Click(object sender, EventArgs e)
        {
            if (adminDashboard2 != null)
                adminDashboard2.Visible = false;

            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = true;

            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;

            if (cashierOrders1 != null)
                cashierOrders1.Visible = false;

            AdminAddProducts aapForm = adminAddProducts1 as AdminAddProducts;
            if (aapForm != null)
            {
                aapForm.refreshData();
            }

        }

        private void orders_Click(object sender, EventArgs e)
        {
            if (adminDashboard2 != null)
                adminDashboard2.Visible = false;

            if (adminAddProducts1 != null)
                adminAddProducts1.Visible = false;

            if (cashierCustomersForm1 != null)
                cashierCustomersForm1.Visible = false;

            if (cashierOrders1 != null)
                cashierOrders1.Visible = true;

            CashierOrders coForm = cashierOrders1 as CashierOrders;
            if (coForm != null)
            {
                coForm.refreshData();
            }
        }
    }
}
