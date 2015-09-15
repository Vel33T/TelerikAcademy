using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class DepositAccount : Account, IDrawable
    {
        public DepositAccount(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public void WithDraw(double amount)
        {
            this.Balance -= amount;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (this.Balance < 1000)
            {
                return 0;
            }
            else
            {
                return base.CalculateInterestAmount(months);
            }

        }
    }
}
