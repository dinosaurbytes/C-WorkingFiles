using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductsWithTextFile
{
    public partial class frmProducts : Form
    {

        List<Product> inventory = new List<Product>(); // empty list
        public frmProducts()
        {
            InitializeComponent();
        }


        private void frmProducts_Load(object sender, EventArgs e)
        {
            inventory = ProductDB.ReadProducts();
            DisplayProducts();
        }
        private decimal CalculateTotal()
        {
            decimal total = 0;
            foreach (Product p in inventory)
                total += p.InventoryValue();
            return total;
        }
        private void DisplayProducts()
        {
            lstProducts.Items.Clear(); // start with empty list box
            foreach (Product p in inventory)
                lstProducts.Items.Add(p); // calls ToString()
            
            lblNrProducts.Text = inventory.Count.ToString();
            lblInventory.Text = CalculateTotal().ToString("c");
        }


        private void frmProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            ProductDB.SaveProducts(inventory);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // get inputs, create product, and add to inventory
            Product p = new Product();
            p.Name = txtName.Text;
            p.Price = Convert.ToDecimal(txtPrice.Text);
            p.Quantity = Convert.ToInt32(txtQty.Text);
            inventory.Add(p);
            // re-display products
            DisplayProducts();
        }
    }
}
