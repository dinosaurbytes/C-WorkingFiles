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

namespace ReplaceDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // string output = input.Replace("key ", "keyword ");

            txtStringFinal.Text = txtString.Text.Replace(txtOld.Text, txtNew.Text);




            ////Regex to replace 1st occurance
            //string str = txtString.Text;
            //Regex regReplace = new Regex(txtOld.Text);
            //txtStringFinal.Text = regReplace.Replace(str, txtNew.Text, 2);
        }
    }
}
