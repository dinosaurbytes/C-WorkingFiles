using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FutureValue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            TextBox trouble = null;
            try
            {
                trouble = txtMonthlyInvestment;
                decimal monthlyInvestment =
                    Convert.ToDecimal(txtMonthlyInvestment.Text);

                trouble =  txtInterestRate;
                decimal yearlyInterestRate =
                    Convert.ToDecimal(txtInterestRate.Text);
                trouble = txtYears;
                int years = Convert.ToInt32(txtYears.Text);
                if (monthlyInvestment <= 0)
                {
                    MessageBox.Show("Monthly investment has to be positive", "Entry error");
                    txtMonthlyInvestment.Focus();
                }
                else if(yearlyInterestRate <= 0 )
                {
                    MessageBox.Show("Yearly interest rate has to be positive", "Entry error");
                    txtInterestRate.Focus();
                }
                else if(years <= 0)
                {
                    MessageBox.Show("Years has to be positive", "Entry error");
                    txtYears.Focus();
                }
                else // all data positive
                {

                    decimal monthlyInterestRate = yearlyInterestRate / 12 / 100;
                    int months = years * 12;

                    decimal futureValue = CalculateFutureValue(
                        monthlyInvestment, monthlyInterestRate, months);
                    txtFutureValue.Text = futureValue.ToString("c");
                    txtMonthlyInvestment.Focus();
                }
                
            }        
            catch (FormatException)
            {
                MessageBox.Show(
                    "Invalid numeric format: " + trouble.Tag,
                    "Entry Error");
                trouble.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show(
                    "Overflow error: " + trouble.Tag,
                    "Entry Error");
                trouble.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    ex.GetType().ToString());
            }
        }

        private decimal CalculateFutureValue(decimal monthlyInvestment,
           decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment)
                    * (1 + monthlyInterestRate);
            }

            return futureValue;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}