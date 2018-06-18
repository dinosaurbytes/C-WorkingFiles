using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    /* 
     * good habbit to create class as public (incase you are creating libraries)
     * Good idea to provide a constructor. Which is a string method. Constructors do not have a return type. Constructor has same method name of the class.
     */
    public class Product
    {
        //private data (typically lowercase)
        //private string name;
        private decimal price;
        private int quantity;

        //AUTO-IMPLEMENTED PROPERTY (SHORTER METHOD)
        /*
         * Compiler creates hidden variable with no name
         * YOu can now get ride of private data in lines 16-18
         */
         public string Name { get; set; }







        //ACCESSOR PROPERTY (LONGER WAY)
        /*
         * Typically use captial for accessors 
         */
        //public string Name
        //{
        //    get
        //    {
        //        return name;
        //    }
        //    set
        //    {
        //        name = value; //value provided when setting, value on right hand side of assignment "big box" for example
        //    }
        //}
        public decimal Price
        {
            get { return price; }
            set { price = (value < 0) ? price = 0 : value;}
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = (value < 0) ? quantity = 0 : value; }
        }

        //public Product() {}

        //create constructor. 
        /*
         * Providing default values, allows you to avoid having an empty consturctor "Product()"
         */
        public Product(string n = "Unknown", decimal p = 0, int q = 0)
        {
            Name = n;           //Use captial, same of accessors
            Price = p;
            Quantity = q;
        }

        //METHOD
        public decimal InventoryValue()
        {
            return price * quantity;
        }

        //method
        /*
         * methods are typically public
         * can define a method ToString
         * trick needs to use override or else it creates a totally seperate method. 
         * allows writing of the data automatically
         */
         public  override string ToString()
        {
            return Name + ": " + price.ToString("c") + " - " + quantity.ToString();
        }
    }
}
