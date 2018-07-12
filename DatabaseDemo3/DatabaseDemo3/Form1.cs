using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseDemo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            try
            {
                this.productsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);
            }
            catch(DBConcurrencyException)
            {
                MessageBox.Show("Another user changed data. Try again.", "Concurrency Exception");
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error while saving: " + ex.Message, ex.GetType().ToString());

            }
            catch (Exception ex)
            {
                MessageBox.Show("Other error while saving: " + ex.Message, ex.GetType().ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.
            try
            {
                this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
            }
            catch(SqlException ex)
            {
                MessageBox.Show("Database error while loading: " + ex.Message, ex.GetType().ToString());

            }
            catch(Exception ex)
            {
                MessageBox.Show("Other error while loading: " + ex.Message, ex.GetType().ToString());
            }
        }
    }
}
