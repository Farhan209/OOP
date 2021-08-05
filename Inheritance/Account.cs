using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Account : Person
    {
        public Account() { }
        public double GetAccountBalance()
        {
            return CurretAccount;
        }
        public double SetAccountBalance(double amount)
        {
            CurretAccount = CurretAccount + amount;
            return CurretAccount;
        }
        public double WithdrawFromAccount(double amountToWithdraw)
        {
            CurretAccount = CurretAccount - amountToWithdraw;
            return CurretAccount;
        }
    }
}
