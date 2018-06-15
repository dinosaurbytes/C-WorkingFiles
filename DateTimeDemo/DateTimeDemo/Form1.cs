using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Today.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();

            //txtDate.Text = DateTime.Today.ToShortDateString();
            //txtTime.Text = DateTime.Now.ToShortTimeString();

            //txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");
            //txtTime.Text = DateTime.Now.ToString("HH:mm", CultureInfo.InvariantCulture);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Today.ToLongDateString();
            txtTime.Text = DateTime.Now.ToLongTimeString();
        }

        //user selects a date
        private void dtpParty_ValueChanged(object sender, EventArgs e)
        {
            DateTime party = dtpParty.Value.Date;       //party date
            lblMessage.Text = "The party is on: " + party.ToLongDateString();

            // how many dats are to the party
            TimeSpan ts = party.Subtract(DateTime.Today);
            int days = ts.Days;
            if (days > 0)
                lblTimeTillParty.Text = days + " more sleep(s) till the party";
            else if (days == 0)
                lblTimeTillParty.Text = "Party is TODAY!!!";
            else
                lblTimeTillParty.Text = "Sorry you missed the party";

        }
    }
}
