using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    // Permanent employee is a special kind of an employee
    public class PermanentEmployee : Employee           //using inheritance
    {
        //added data
        private decimal rrspPercent;    //decimal, like 0.05 for 5%

        //constructor
        public PermanentEmployee(string n, decimal h, decimal p, decimal r) : base(n, h, p)     //calling base class constructor
        {
            this.rrspPercent = r;
        }

        // public methods
        public decimal CalculateRRSP()
        {
            return base.CalculatePay() * rrspPercent;
        }

        // override inherited method
        public override decimal CalculatePay() 
        {
            return base.CalculatePay() - CalculateRRSP();
        }
        public override string ToString() 
        {
            return base.CommonString() +
                "\nPay before deduction: " + base.CalculatePay() +
                "\nRRSP percent: " + rrspPercent.ToString("p") +
                "\nRRSP amount deducted: " + CalculateRRSP() +
                "\nPay amount: " + CalculatePay();
        }

    }
}
