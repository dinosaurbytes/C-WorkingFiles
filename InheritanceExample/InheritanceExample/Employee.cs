using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class Employee
    {
        // constants and variables
        const decimal FULL_WEEK = 37.5m;
        const decimal OT_RATE = 1.5m;

        private string name;
        private decimal hours;
        private decimal payRate;        // per hour

        // constructor
        public Employee(string n, decimal h, decimal p)
        {
            this.name = n;
            this.hours = h;
            this.payRate = p;
        }

        // public methods
        public virtual decimal CalculatePay()       //virtual key word, means its okay to override
        {
            if (hours <= FULL_WEEK) //Straight time
                return hours * payRate;
            else        //OT applies
                return FULL_WEEK * payRate + (hours - FULL_WEEK) * payRate * OT_RATE;
        }

        protected string CommonString()     // protected is accessible from derived class (otherwise use private)
        {
            return "\n" + name + ": \n" +
                "Hours: " + hours + " at " + payRate.ToString("c");
        }

        public override string ToString()
        {
            return CommonString() +
                "\nPay amount: " + CalculatePay().ToString("c");
        }

    }
}
