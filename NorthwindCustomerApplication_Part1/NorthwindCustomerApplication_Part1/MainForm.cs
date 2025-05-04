using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace NorthwindCustomerApp
{
    public partial class MainForm : Form
    {
        private CustomerBusiness _business;

        public MainForm()
        {
            InitializeComponent();
            _business = new CustomerBusiness();
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            lblCount.Text = "Total Customers: " + _business.GetCustomerCount();
            listBoxLastNames.DataSource = _business.GetCustomerLastNames();
        }
    }
}
