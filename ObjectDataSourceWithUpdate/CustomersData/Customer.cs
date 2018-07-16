using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    public class Customer
    {
        public Customer() { }

        public int CustomerID { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }
        public Customer CopyCustomer()
        {
            Customer copy = new Customer();
            copy.CustomerID = this.CustomerID;
            copy.Name = this.Name;
            copy.Address = this.Address;
            copy.City = this.City;
            copy.State = this.State;
            copy.ZipCode = this.ZipCode;
            return copy;
        }
    }
}
