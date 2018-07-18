using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDdemo
{
    public class Account : AccountInterface
    {
        private decimal balance;
        public decimal Balance { get { return balance; } }


        public Account(decimal amount)
        {
            balance = amount;

        }
        public void Deposit(decimal amount)
        {
            balance = balance + amount;
        }

        public bool Withdraw(decimal amount)
        {
            throw new NotImplementedException();
        }
    }
}
