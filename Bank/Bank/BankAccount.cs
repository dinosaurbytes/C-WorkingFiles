using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class BankAccount
    {
        public decimal Balance { get; private set; }
        public decimal AnnualRate { get; set; }

        //default constructor
        public BankAccount() { }

        //constructor which takes two parameters
        public BankAccount(decimal balance, decimal annualRate)
        {
            if (balance < 0) this.Balance = 0;
            else this.Balance = balance;

            if (annualRate < 0) this.AnnualRate = 0.05m;
            this.AnnualRate = annualRate;
        }

        //methods
        public bool WithDraw(decimal withdraw)
        {
            if (withdraw > Balance)
                return false;
            else if (withdraw < 0)
                return false;
            else
            Balance = Balance - withdraw;
            return true;
        }

        public bool Deposit(decimal deposit)
        {
            
            if (deposit < 0) return false;
            else
                Balance = Balance + deposit;
            return true;
        }

        public void AddMonthlyInterest()
        {
            Balance = Balance + (AnnualRate * Balance);
        }

        public override string ToString()
        {
            return "With annaual interest rate of: " + AnnualRate + "\t Your new balance is:" +  Balance.ToString("c");
        }

    }
}
