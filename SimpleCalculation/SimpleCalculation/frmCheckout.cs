using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculation
{
    public partial class frmCheckout : Form
    {
        // class-level variables and constants - accessible from all methods
        const decimal TAX_RATE = 0.05m; // tax percent as decimal
        public frmCheckout()
        {
            InitializeComponent();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            // local variables - accessibe only in this method
            int quantity;       // quantity purchased
            decimal price;      // product price
            decimal subtotal;   // subtotal before tax
            decimal taxAmount;  // tax to pay
            decimal total;      // total to pay, incl. tax

            // obtain price and quantity
            quantity = Convert.ToInt32(txtQuantity.Text);
            price = Convert.ToDecimal(txtPrice.Text);

            // do calculations
            subtotal = price * quantity;
            taxAmount = subtotal * TAX_RATE;
            total = subtotal + taxAmount;

            // display outputs
            txtSubtotal.Text = subtotal.ToString("c");
            txtTax.Text = taxAmount.ToString("c");
            txtTotal.Text = total.ToString("c");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // erase content of text boxes in preparation for next calculation
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "";
            txtQuantity.Text = "";
            txtSubtotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";
            txtPrice.Focus();
        }

        // display tax prompt
        private void frmCheckout_Load(object sender, EventArgs e)
        {
            lblTaxPrompt.Text = TAX_RATE.ToString("p1") + " Tax Amount";
        }
    }
}
