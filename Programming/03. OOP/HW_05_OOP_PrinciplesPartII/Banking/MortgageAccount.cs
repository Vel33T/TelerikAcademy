using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public class MortgageAccount : Account
    {
        public MortgageAccount(Customer customer, double balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public override double CalculateInterestAmount(int months)
        {
            if (this.Customer is Company)
            {
                if (months <= 12)
                {
                    return months * this.Balance * this.InterestRate / 200;
                }
                else
                {
                    return (12 * this.Balance * this.InterestRate / 200) +
                        ((months - 12) * this.Balance * this.InterestRate / 100);
                }
            }
            else if (this.Customer is Individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    return (months - 6) * this.Balance * this.InterestRate/ 100;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
