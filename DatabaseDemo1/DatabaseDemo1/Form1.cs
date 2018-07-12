using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //User clicks on the save button
        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();       //finalizes the edit
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);   //perform update on the database
            }
            catch (DBConcurrencyException)
            {
                MessageBox.Show("Another user changed data in the meantime. Try again.", "Concurrency Error");
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);      //refresh dataset
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            //retrives data of products into the data set
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);

        }
    }
}
