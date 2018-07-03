using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenance
{
    /// <summary>
    /// CustomerDB class
    /// </summary>
    public static class CustomerDB
	{
        // TODO: Add the directory and path here
        private const string dir = @"C:\Users\792783\source\repos\CSharpSandbox\";
        private const string path = dir + "Products.txt";

        public static void SaveCustomers(List<Customer> customers)
		{
            // TODO: Add code that writes the List<> of Customer objects 
            StreamWriter textOut = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));

            foreach (Customer customer in customers)
            {
                textOut.Write(customer.FirstName + "|");
                textOut.Write(customer.LastName + "|");
                textOut.Write(customer.Email + "|");
            }
            textOut.Close();

            // to a text file
		}

        public static List<Customer> GetCustomers()
		{
            if (!Directory.Exists(dir)) Directory.CreateDirectory(dir);


            // TODO: Add code that reads a List<> of Customer objects 
            StreamReader textIn = new StreamReader(new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read));


            List<Customer> customers = new List<Customer>();

            while (textIn.Peek() != -1)
            {
                string row = textIn.ReadLine();
                string[] columns = row.Split('|');
                Customer customer = new Customer();
                customer.FirstName = columns[0];
                customer.LastName = columns[1];
                customer.Email = columns[2];
                customers.Add(customer);
            }


            // from a text file
            textIn.Close();

            return customers;
		}
	}
}
