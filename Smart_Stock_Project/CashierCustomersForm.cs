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
    public partial class CashierCustomersForm : UserControl
    {
        public CashierCustomersForm()
        {
            InitializeComponent();
            if (!DesignMode)
            {
                if (!LicenseManager.UsageMode.Equals(LicenseUsageMode.Designtime))
                {
                    displayCustomersData();
                }

            }
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCustomersData();


        }


        private void CashierCustomersForm_Load(object sender, EventArgs e)
        {
            //if (!DesignMode)
            //{
            //    displayCustomersData();
            //}
        }

        private void all_customer_label_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void displayCustomersData()
        {
            CustomersData cData = new CustomersData();
            List<CustomersData> listData = cData.AllCustomersData();

            dataGridView1.DataSource = listData;
            dataGridView1.Columns["CustomerID"].HeaderText = "Customer ID";
            dataGridView1.Columns["TotalPrice"].HeaderText = "Total Price";
            dataGridView1.Columns["Amount"].HeaderText = "Amount Paid";
            dataGridView1.Columns["ChangeAmount"].HeaderText = "Change Amount";
            dataGridView1.Columns["OrderDate"].HeaderText = "Order Date";
        }
    }
}
