using System;
using System.Collections.Generic;
using System.Text;

namespace DOP.Tests.Models
{
    public class Account
    {
        public decimal Balance { get; set; }
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }
    }
}
