using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoicesData
{
    public static class InvoiceDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=MMABooks;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);        //Sql connection object con
            return con;
        }

        public static List<Invoice> GetInvoices()
        {
                List<Invoice> invoices = new List<Invoice>();      //Empty list
                Invoice inv;        //for reading
                SqlConnection connection = GetConnection();
                string selectStatement = "SELECT InvoiceID, CustomerID, InvoiceDate, ProductTotal, SalesTax, Shipping, InvoiceTotal " +
                                            "FROM Invoices ORDER BY InvoiceID";
                SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader dr = selectCommand.ExecuteReader();
                while (dr.Read())
                {
                    inv = new Invoice();
                    inv.InvoiceID = (int)dr["InvoiceID"];
                    inv.CustomerID = (int)dr["CustomerID"];
                    inv.InvoiceDate = (DateTime)dr["InvoiceDate"];
                    inv.ProductTotal = (decimal)dr["ProductTotal"];
                    inv.SalesTax = (decimal)dr["SalesTax"];
                    inv.Shipping = (decimal)dr["Shipping"];
                    inv.InvoiceTotal = (decimal)dr["InvoiceTotal"];
                    invoices.Add(inv);
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
                
                return invoices;
        }

    }
}

