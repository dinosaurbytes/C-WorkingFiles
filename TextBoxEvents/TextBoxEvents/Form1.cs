using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextBoxEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //allow only letters, dash, space, single quotes, and backspace
        //ignore anything else
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // e.KeyChar contains character press
            //e.Handled is a bool flag that indicates that it's done
            if (!char.IsLetter(e.KeyChar) &&     //not a letter
                e.KeyChar != ' ' &&              //not a space
                e.KeyChar != '-' &&              //not a dash
                e.KeyChar != '\'' &&             //not a single quote
                e.KeyChar != (char) Keys.Back)    //not backspace
            {
                e.Handled = true; //ignore it
            }

        }

        //check fo rproper postalcode format using regular expression
        private void txtPostalCode_Validating(object sender, CancelEventArgs e)
        {
            Regex pattern = new Regex("^([a-zA-Z][0-9]){3}$");
            TextBox tb = (TextBox)sender;
            if (!pattern.IsMatch(tb.Text))
            {
                MessageBox.Show("Postal code should be letter digit repeated 3 times", "Postal Code Error");
                tb.SelectAll();
                tb.Focus();
            }
        }
    }
}
