using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public static class StateDB
    {
        public static List<State> GetStates()      //state list defined called GetStates()
        {
            List<State> states = new List<State>();     //empty

            //Step 1 Connection
            SqlConnection connection = MMABooksDB.GetConnection();          // getting connection form the MMABooksDB class

            //Step 2 Command
            string selectStatement = "SELECT StateCode, StateName FROM States ORDER BY StateName";  //SQL command
            SqlCommand cmd = new SqlCommand(selectStatement, connection);   //Takes two parameters, the stament and the connection
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                State s;
                while (reader.Read())       //while there is another record
                {
                    s = new State();      //new state object
                    s.StateCode = reader["StateCode"].ToString();
                    s.StateName = reader["StateName"].ToString();
                    states.Add(s);

                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return states;

            
        }
    }
}
