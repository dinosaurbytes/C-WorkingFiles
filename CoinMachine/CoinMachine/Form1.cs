using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoinMachine
{
    public partial class CoinMachine : Form
    {
        public CoinMachine()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // List of constants
            const decimal toonie = 2.00m;
            const decimal loonie = 1.00m;
            const decimal quarter = 0.25m;
            const decimal dime = 0.10m;
            const decimal nickel = 0.05m;

            // List of variabes
            
            decimal numToonies;
            decimal numLoonies;
            decimal numQuarters;
            decimal numDimes;
            decimal numNickels;
            decimal change;
            int numCoins;

            //Calculate number of toonies
            numToonies = Convert.ToDecimal(txtInput.Text)/toonie;
            txtToonie.Text = Convert.ToInt32(Math.Floor(numToonies)).ToString();
            change = Convert.ToDecimal(txtInput.Text) % toonie;

            //Calculate number of loonies
            numLoonies = Convert.ToDecimal(change) / loonie;
            txtLoonie.Text = Convert.ToInt32(Math.Floor(numLoonies)).ToString();
            change = change % loonie;

            //Calculate number of quarters
            numQuarters = Convert.ToDecimal(change) / quarter;
            txtQuarter.Text = Convert.ToInt32(Math.Floor(numQuarters)).ToString();
            change = change % quarter;

            //Calculate number of dimes
            numDimes = Convert.ToDecimal(change) / dime;
            txtDime.Text = Convert.ToInt32(Math.Round(numDimes,2,MidpointRounding.AwayFromZero)).ToString();
            change = change % dime;

            //Calculate number of nickels
            numNickels = Convert.ToDecimal(change) / nickel;
            txtNickel.Text = Convert.ToInt32(Math.Round(numNickels * 20) / 20).ToString();
            change = change % nickel;

            //Calculate number of coins
            numCoins = Convert.ToInt32(Math.Floor(numToonies)) + Convert.ToInt32(Math.Floor(numLoonies)) + Convert.ToInt32(Math.Floor(numQuarters)) + Convert.ToInt32(Math.Floor(numDimes)) + Convert.ToInt32(Math.Floor(numNickels));
            txtCoins.Text = numCoins.ToString();







        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtToonie.Text = "";
            txtLoonie.Text = "";
            txtQuarter.Text = "";
            txtDime.Text = "";
            txtNickel.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
