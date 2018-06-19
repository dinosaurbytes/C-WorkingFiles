using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsWithTextFile
{
    public class Product
    {
        // private data and public accessors
        public string Name { get; set; }

        private decimal price;
        public decimal Price
        {
            get { return price; }
            set { price = (value < 0) ? 0 : value; }           
        }

        private int quantity;
        public int Quantity
        {
            get { return quantity; }
            set { quantity = (value < 0) ? 0 : value; }
        }

        // constructor
        public Product(string n = "Unknown", decimal p = 0, int q= 0)
        {
            Name = n;
            Price = p;
            Quantity = q;
        } 

        // methods
        public decimal InventoryValue()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            return Name + ": " + Price.ToString("c") + " - " + Quantity.ToString();
        }
        public string ToFileLine()
        {
            return Name + ", " + Price.ToString() + ", " + Quantity.ToString();
        }
    }
}
