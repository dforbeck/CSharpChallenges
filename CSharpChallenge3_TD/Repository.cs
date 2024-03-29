﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpChallenge3_TD
{
      public class Repository
       
        {
            public double Balance { get; private set; }
            public double OverdraftLimit { get; private set; }

            public Account(double overdraftLimit)
            {
                this.OverdraftLimit = overdraftLimit > 0 ? overdraftLimit : 0;
                this.Balance = 0;
            }

            public bool Deposit(double amount)
            {
                if (amount >= 0)
                {
                    this.Balance += amount;
                    return true;
                }
                return false;
            }

            public bool Withdraw(double amount)
            {
                if (this.Balance - amount >= -this.OverdraftLimit && amount >= 0)
                {
                    this.Balance -= amount;
                    return true;
                }
                return false;
            }
        }
}
