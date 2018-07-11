using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        { 
            BankAccount account1 = new CheckingAccount(300,0.6m,1000);
            account1.AddMonthlyInterest();
            Console.WriteLine(account1.ToString());
            account1.Deposit(500);
            Console.WriteLine(account1.ToString());
            Console.ReadKey();
        }
    }
}
