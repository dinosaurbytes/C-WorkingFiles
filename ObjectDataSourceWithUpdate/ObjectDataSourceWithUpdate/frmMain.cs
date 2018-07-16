using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectDataSourceWithUpdate
{
    public partial class frmMain : Form
    {
        List<Customer> customers;   //List of all customers
        Customer oldcustomer;
        const int EDIT_BUTTON_INDX = 6;     //column in the grid that contains the edit buttons
        public frmMain()
        {
            InitializeComponent();
        }

        //Porcess user clicking on the edit button (column with index 6)
        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == EDIT_BUTTON_INDX)
            {
                oldcustomer = customers[e.RowIndex].CopyCustomer(); //make a separate copy before update
                frmUpdate updateform = new frmUpdate();
                updateform.customer = customers[e.RowIndex];
                updateform.oldCustomer = oldcustomer;
                DialogResult result = updateform.ShowDialog();
                if(result == DialogResult.OK)
                {
                    //refresh the grid view
                    CurrencyManager cm = (CurrencyManager) customerDataGridView.BindingContext[customers];
                    cm.Refresh();
                }
                else
                {
                    customers[e.RowIndex] = oldcustomer;    //revert to the old values
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                customers = CustomerDB.GetAllCustomer();
                customerDataGridView.DataSource = customers;    //bind the gird view to the customers list
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while loading chustomers data: " + ex.Message, ex.GetType().ToString());
            }

        }
    }
}
