using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calling constructor without any paramaters
            Product prod1 = new Product();
            Product prod2 = new Product("Gadget");
            Product prod3 = new Product("Widget", 4.99m);
            Product prod4 = new Product("Gizmo", 2.99m, 15);
            Product prod5 = new Product("Dummy", -1.99m, -10);

            //Create a list of products
            List<Product> inventory = new List<Product>();      //empty list
            inventory.Add(prod1);
            inventory.Add(prod2);
            inventory.Add(prod3);
            inventory.Add(prod4);
            inventory.Add(prod5);


            //testing accessor properties
            prod1.Name = "big box";     //this line uses the set part of the accessor property
            //Console.WriteLine("The first product is " + prod1.Name);        //this line uses the get part
            prod1.Price = -5;

            //Displays on console
            //Console.WriteLine(prod1);
            //Console.WriteLine(prod2);
            //Console.WriteLine(prod3);
            //Console.WriteLine(prod4);
            //Console.WriteLine(prod5);

            //One method of displaying is using element index
            //for (int i = 0; i < inventory.Count; i++)
            //    Console.WriteLine(inventory[i]);        // Can access list elemetn using index

            //2nd method of displaying is using foreach
            foreach (Product p in inventory)
                Console.WriteLine(p);

            //Calculate the inventory value
            decimal total = 0;
            foreach (Product p in inventory)
                total += p.InventoryValue();
            Console.WriteLine("\nTotal inventory: " + total.ToString("c"));

            Console.WriteLine("\n\nPress any key to finish");
            Console.ReadKey();
        }
    }
}
