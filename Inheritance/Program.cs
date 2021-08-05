using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account();
            double currentAmount = 0.0;

            currentAmount = myAccount.SetAccountBalance(1000.00);
            Console.WriteLine("Current Amount: {0}", currentAmount);

            currentAmount = myAccount.WithdrawFromAccount(200.00);
            Console.WriteLine("Current Amount: {0}", currentAmount);

            currentAmount = myAccount.GetAccountBalance();
            Console.WriteLine("Current Amount: {0}", currentAmount);
            Console.ReadLine();
        }
    }
}
