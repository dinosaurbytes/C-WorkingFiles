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
    public partial class frmUpdate : Form
    {
        public Customer customer;       //current customer
        public Customer oldCustomer;    //original customer data
        public frmUpdate()
        {
            InitializeComponent();
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            //Load the states into the combo box
            List<State> states = StateDB.GetStates();
            stateComboBox.DataSource = states;
            stateComboBox.DisplayMember = "StateName";
            stateComboBox.ValueMember = "StateCode";

            //Bind the controls to the customer object
            customerBindingSource.Clear();
            customerBindingSource.Add(customer);
        }

        private void customerIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void customerIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void zipCodeLabel_Click(object sender, EventArgs e)
        {

        }

        //user cancels the update
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Set dialog result to retry
            this.DialogResult = DialogResult.Retry;
            
        }
        //user accepts the update
        private void btnAccept_Click(object sender, EventArgs e)
        {
            bool success = CustomerDB.UpdateCustomer(oldCustomer, customer);
            if (success)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.Retry;
            }
        }
    }
}
