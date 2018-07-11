using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class CheckingAccount : BankAccount
    {
        public decimal OverdraftLimit { get; set; }

        public CheckingAccount() { }

        public CheckingAccount(decimal balance, decimal annualRate, decimal overdraftLimit): base(balance, annualRate)
        {
            if (overdraftLimit > 0) overdraftLimit = -overdraftLimit;
            this.OverdraftLimit = overdraftLimit;
        }

        public void Withdraw(decimal withdraw) : base
        {
            if (Balance - withdraw <= OverdraftLimit)
                return false;
        }

        public override string ToString()
        {
            return "Your balance is: " + Balance + "Your overdraft limit is: "+ OverdraftLimit;
        }





    }
}
