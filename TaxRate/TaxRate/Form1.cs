using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxRate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal remainingSalary = Convert.ToInt32(txtSalaryInput.Text);
            decimal taxBracketAmount;
            decimal bracket80K = 0;
            decimal bracket50K = 0;
            decimal bracket30K = 0;
            decimal bracket15K = 0;
            decimal bracketU15K = 0;
            decimal totalTaxAmount;

            if (remainingSalary > 80000)
            {
                taxBracketAmount = remainingSalary - 80000;
                bracket80K = taxBracketAmount * 0.33m;
                remainingSalary = remainingSalary - taxBracketAmount;
            }
            if (remainingSalary > 50000)
            {
                taxBracketAmount = remainingSalary - 50000;
                bracket50K = taxBracketAmount * 0.27m;
                remainingSalary = remainingSalary - taxBracketAmount;
            }
            if (remainingSalary > 30000)
            {
                taxBracketAmount = remainingSalary - 30000;
                bracket30K = taxBracketAmount * 0.22m;
                remainingSalary = remainingSalary - taxBracketAmount;
            }
            if (remainingSalary > 15000)
            {
                taxBracketAmount = remainingSalary - 15000;
                bracket15K = taxBracketAmount * 0.18m;
                remainingSalary = remainingSalary - taxBracketAmount;
            }
            if (remainingSalary <= 15000)
            {
                bracketU15K = remainingSalary * 0.15m;
            }
            

            totalTaxAmount = bracketU15K + bracket15K + bracket30K + bracket50K + bracket80K;
            txtTaxAmount.Text = totalTaxAmount.ToString("c");
        }
    }
}
