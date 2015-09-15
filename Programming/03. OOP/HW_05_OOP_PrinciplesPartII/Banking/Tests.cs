using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Tests
    {
        static void Main()
        {

            List<Account> accounts = new List<Account>()
                {
                    new DepositAccount(new Individual("Ivancho", "000000"), 1000, 8.5),
                    new DepositAccount(new Company("Ivancho EOOD", "111111"), 1000, 8.5),
                    new MortgageAccount(new Individual("Marijka", "222222"), 1000, 8.5),
                    new MortgageAccount(new Company("Marijka EOOD", "333333"), 1000, 8.5),
                    new LoanAccount(new Individual("Vute", "444444"), 1000, 8.5),
                    new LoanAccount(new Company("Vute EOOD", "555555"), 1000, 8.5),
                };

            accounts[0].Deposit(100);
            //accounts[5].Deposit(1000);
            int months = 5;
            foreach (Account acc in accounts)
            {
                Console.WriteLine("{0} {1} {2}", acc.Customer.Name, acc.Balance, acc.CalculateInterestAmount(months));
            }
        }
    }
}
