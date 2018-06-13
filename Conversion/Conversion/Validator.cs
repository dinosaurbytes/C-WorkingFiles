using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversion
{
    public static class Validator
    {
        // Test if text box contains anything
        public static bool IsProvided(TextBox inputBox, string name)
        {
            bool result = true;         //innocent until proven guilty

            if (inputBox.Text == "")    //if the input is bad
            {
                result = false;
                MessageBox.Show(name + " has to be provided");
                inputBox.SelectAll();
                inputBox.Focus();

            }
           
            return result;
        }

        // Test if text box contains integer value
        public static bool IsNonNegativeInteger(TextBox inputBox, string name)
        {
            bool result = true;
            int val;    //to capture value from TryParse
            if(!Int32.TryParse(inputBox.Text, out val))
            {
                result = false;
                MessageBox.Show(name + " must be a whole number");
                inputBox.SelectAll();
                inputBox.Focus();
            }
            else // it is an integer
            {
                if (val < 0)        //bad
                {
                    result = false;
                    MessageBox.Show(name + " must be zero or more");
                    inputBox.SelectAll();
                    inputBox.Focus();
                }
            }

            return result;
        }

        // Test if text box contains positive double valve
        public static bool IsPositiveDouble(TextBox inputBox, string name)
        {
            bool result = true;
            double val;    //to capture value from TryParse
            if (!Double.TryParse(inputBox.Text, out val))
            {
                result = false;
                MessageBox.Show(name + " must be a decimal number");
                inputBox.SelectAll();
                inputBox.Focus();
            }
            else // it is a double
            {
                if (val <= 0)        //bad
                {
                    result = false;
                    MessageBox.Show(name + " must be greater than zero");
                    inputBox.SelectAll();
                    inputBox.Focus();
                }
            }

            return result;
        }

    }
}
