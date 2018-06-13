using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public partial class Form1 : Form
    {
        const double CM_IN_INCH = 2.54;
        const int INCHES_IN_FOOT = 12;


        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtCM_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnToMetric_Click(object sender, EventArgs e)
        {
            int feet, inches;       //inputs
            double cm;              //output

            //get feet and inches
            feet = Convert.ToInt32(txtFeet.Text);
            inches = Convert.ToInt32(txtInches.Text);

            //calcualte centimeters
            cm = ToMetric(feet, inches);

            //display centimeters
            txtCM.Text = cm.ToString("f2");
        }

        //method that receives feet and inches and converts to cm
        private double ToMetric(int f, int i)
        {
            double c = 0;
            int TotalInches = f * INCHES_IN_FOOT + i;
            c = TotalInches * CM_IN_INCH;
     
            return c;
        }

        //method that receives cm and converts to feet and inches
        private void ToImperial(double c, out int f, out int i)
        {
            int totalInches = (int)Math.Round(c / CM_IN_INCH);
            f = totalInches / INCHES_IN_FOOT;
            i = totalInches % INCHES_IN_FOOT;
        }

        private void btnToImperial_Click(object sender, EventArgs e)
        {
            double cm;              //input
            int feet, inches;       //outputs

            //get centimeters
            cm = Convert.ToDouble(txtCM.Text);

            //convert to feet and inches
            ToImperial(cm, out feet, out inches);

            //display feet and inches
            txtFeet.Text = feet.ToString();
            txtInches.Text = inches.ToString();
        }
    }
}

