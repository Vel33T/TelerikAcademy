namespace ATMDatabase.Models
{
    using System;

    public class TransactionHistory
    {
        public int Id { get; set; }

        public string CardNumber { get; set; }

        public DateTime TransactionDate { get; set; }

        public decimal Ammount { get; set; }
    }
}
