using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class LoanAccount : Account
    {
        public LoanAccount(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (this.Customer is Individual && months > 3)
            {
                return (months - 3) * this.InterestRate * this.Balance / 100;
            }
            else if (this.Customer is Company && months > 2)
            {
                return (months - 2) * this.InterestRate * this.Balance / 100;
            }
            else
            {
                return 0;
            }
        }
    }
}
