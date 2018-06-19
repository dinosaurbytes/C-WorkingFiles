using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsWithTextFile
{
    public static class ProductDB
    {
        const string path = "products.txt";

        /// <summary>
        /// Reads data from the file if exists; or creates an empty file
        /// </summary>
        /// <returns>
        /// List of products if file existed, or empty list otherwise
        /// </returns>
        public static List<Product> ReadProducts()
        {
            List<Product> products = new List<Product>(); // empty list
            FileStream fs = null;
            StreamReader sr = null;

            // for reading
            string line;
            string[] parts;
            Product prod; 
            try
            {
                // open the file for reading (the very first time, the file does not exist)
                fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);
                sr = new StreamReader(fs);
                // read data
                while (!sr.EndOfStream) // while there is still data
                {
                    line = sr.ReadLine();
                    parts = line.Split(','); // split where commas are
                    // create another product and add to the list
                    prod = new Product();
                    prod.Name = parts[0];
                    prod.Price = Convert.ToDecimal(parts[1]);
                    prod.Quantity = Convert.ToInt32(parts[2]);
                    products.Add(prod);
                }

            }
            catch (Exception ex)
            {
                throw ex; // pass it to the calling code
            }
            finally
            {
                if (sr != null) sr.Close();
            }
            return products;
        }

        public static void SaveProducts(List<Product> products)
        {
            FileStream fs = null;
            StreamWriter sw = null;
            try
            {
                // open the file for writing; overwrite old content
                fs = new FileStream(path, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs);

                // save data
                //for (int i = 0; i < products.Count; i++) // for each product
                //{
                //    sw.WriteLine(products[i].ToFileLine());
                //}
                foreach (Product p in products)
                    sw.WriteLine(p.ToFileLine());

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (sw != null) sw.Close();
            }
        }
    }
}
