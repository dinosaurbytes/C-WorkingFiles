using System;
using System.Collections.Generic;
using System.Data.SqlClient; //ADO.NET data provider for Sql Server
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public static class MMABooksDB
    {
        public static SqlConnection GetConnection()     //prepares the connection object 
        {
            string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=MMABooks;Integrated Security=True";
            SqlConnection con = new SqlConnection(connectionString);        //Connection string object
            return con;             // return the object 
        }
    }
}
