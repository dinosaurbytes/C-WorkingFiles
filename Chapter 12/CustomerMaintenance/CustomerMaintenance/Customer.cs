using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerMaintenance
{
    public class Customer
    {
        //Properties
        private string firstName;
        private string lastName;
        private string email;

        //Constructor Empty
        public Customer() { }

        //Constructor with requirements
        public Customer(string firstName, string lastName, string email)
		{
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Email = email;
		}

        //Acessors
        public string FirstName
        {
            get  { return firstName;}
            set  {firstName = value;}
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        //Method 
        public string GetDisplayText() => firstName + lastName + ", " + email;

    }
}
