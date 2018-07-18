using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDDdemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDdemo.Tests
{
    [TestClass()]
    public class AccountTests
    {
        [TestMethod()]
        public void DepositTestIgnore()
        {
            //Arrange
            Account acct = new Account(100);
            decimal depositAmount = 200;
            decimal expectedBalance = 300;
            decimal actualBalance;
            //Act
            acct.Deposit(depositAmount);
            actualBalance = acct.Balance;

            //Assert
            Assert.AreEqual(actualBalance, expectedBalance);
        }
    }
}