using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Purpose: Our first application
 * Author: Brian Liang
 * Date: June 12, 2018
 */

namespace HelloWorld
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        // reaction to user clicking on the button
        private void btnGreet_Click(object sender, EventArgs e)
        {
            // personalize greeting
            lblGreeting.Text = "Hello " + txtName.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Hello World";
            txtName.Text = "";
            txtName.Select(); // Put a cursor inside the textbox
        }

        //Executes as the application starts
        private void frmHello_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }

        // Stop the application
        private void btnExit_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Close();
        }
    }
}
