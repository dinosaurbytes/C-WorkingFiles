using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleArray
{
    public partial class Form1 : Form
    {
        //create an array of numbers
        const int MAX_SIZE = 10;

        double[] myNumbers = new double[MAX_SIZE];
        int count = 0;      //how many numbers do we have
        double total = 0;
        


        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double num; // for reading next number
                //get the number
                num = Convert.ToDouble(txtNumber.Text);
                //add it to the array
                myNumbers[count] = num;         //next available position is the count
                count++;
                //display in the list box
                lstMyNumbers.Items.Add(num);
                //update total
                total += num;
                lblTotoal.Text = total.ToString();
                //update smallest and largest
                FindSmallestAndLargest();

                // erase entry box
                txtNumber.Text = "";
                //check if full and disable Add button
                if (count == MAX_SIZE)
                {
                    btnAdd.Enabled = false;
                }
                else        //still more room
                {
                    txtNumber.Focus(); //prepare for next entry
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("A decimal number is expected", "Entry Error");
                txtNumber.Focus();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you entered is too long", "Overflow Error");
                txtNumber.SelectAll();
                txtNumber.Focus();
            }
            catch (Exception ex)            // any other error, last resort
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                txtNumber.SelectAll();
                txtNumber.Focus();
            }

        }

        private void FindSmallestAndLargest()
        {
            double smallest, largest;
            smallest = largest = myNumbers[0];      //we know there is at least one number
            for (int i=1; i<count; i++)     //check all other elements
            {
                if (myNumbers[i] < smallest)
                {
                    smallest = myNumbers[i];
                    lblSmallest.Text = myNumbers[i].ToString();
                }
                else if (myNumbers[i] > largest)
                {
                    largest = myNumbers[i];
                    lblLargest.Text = myNumbers[i].ToString();
                }
            }
            lblSmallest.Text = smallest.ToString();
            lblLargest.Text = largest.ToString();
        }
    }
}
