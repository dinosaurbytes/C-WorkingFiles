using InvoicesData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoicesDemo
{
    public partial class Form1 : Form
    {
        List<Invoice> invoices = null; //had to refactor the inovice to initalize it

        public Form1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            invoices = InvoiceDB.GetInvoices();
            invoiceDataGridView.DataSource = invoices;
        }
    }
}
