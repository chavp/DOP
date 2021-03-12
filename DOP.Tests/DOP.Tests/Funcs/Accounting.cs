using DOP.Tests.Datas;
using System;
using System.Collections.Generic;
using System.Text;

namespace DOP.Tests.Funcs
{
    public static class Accounting
    {
        public static AccountData Withdraw(this AccountData data, decimal amount)
        {
            return new AccountData { Balance = data .Balance - amount };
        }

        public static AccountData Deposit(this AccountData data, decimal amount)
        {
            return new AccountData { Balance = data.Balance + amount };
        }
    }
}
