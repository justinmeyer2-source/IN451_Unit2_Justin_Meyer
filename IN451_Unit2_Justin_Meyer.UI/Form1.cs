using System;
using System.Configuration;
using System.Windows.Forms;
using IN451_Unit2_Justin_Meyer.Business;

namespace IN451_Unit2_Justin_Meyer.UI
{
    public partial class Form1 : Form
    {
        private readonly CustomerService _service;

        public Form1()
        {
            InitializeComponent();

            var cs = ConfigurationManager.ConnectionStrings["Northwind"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(cs))
            {
                MessageBox.Show("Missing 'Northwind' connection string in App.config.", "Config Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
                return;
            }

            _service = new CustomerService(cs);
        }

        private void btnLoadNames_Click(object sender, EventArgs e)
        {
            try
            {
                lstCustomers.DataSource = _service.GetCustomerNames();
                lblCount.Text = $"Customers: {_service.GetCustomerCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading names: {ex.Message}");
            }
        }

        private void btnLoadLastNames_Click(object sender, EventArgs e)
        {
            try
            {
                lstCustomers.DataSource = _service.GetCustomerLastNames();
                lblCount.Text = $"Customers: {_service.GetCustomerCount()}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading last names: {ex.Message}");
            }
        }
    }
}
