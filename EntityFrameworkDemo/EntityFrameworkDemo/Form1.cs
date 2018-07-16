using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        MMABooksEntities context = new MMABooksEntities();  //object context

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var customers = (from customer in context.Customers.Include("Invoices")
                             orderby customer.CustomerID
                             select customer).ToList();     //ToList() executes the LINQ query
            customerBindingSource.DataSource = customers;

        }

        private void invoicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void customerIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int customerID = (int)customerIDComboBox.SelectedItem;
            var customerInvoices = (from invoice in context.Invoices
                                    where invoice.CustomerID == customerID
                                    orderby invoice.InvoiceID
                                    select invoice).ToList();       //list of invoices for selected customer
            invoicesBindingSource.DataSource = customerInvoices;
        }
    }
}
