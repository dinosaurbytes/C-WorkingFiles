﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDdemo
{
    public interface AccountInterface
    {
        void Deposit(decimal amount);
        bool Withdraw(decimal amount);


    }
}
