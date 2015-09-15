using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Banking
{
    public abstract class Account : IDepositable
    {
        public Customer Customer { get; set; }
        public double Balance { get; set; }
        public double InterestRate { get; set; }

        public void Deposit(double amount)
        {
            this.Balance += amount;
        }

        public virtual double CalculateInterestAmount(int months)
        {
            return months * this.InterestRate * this.Balance / 100;
        }
    }
}
