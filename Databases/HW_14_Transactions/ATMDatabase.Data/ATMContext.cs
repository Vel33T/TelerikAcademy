namespace ATMDatabase.Client.Data
{
    using System.Data.Entity;
    using ATMDatabase.Models;

    public class ATMContext : DbContext
    {
        public ATMContext()
            : base("ATMDB")
        {
        }

        public DbSet<CardAccount> CardAccounts { get; set; }

        public DbSet<TransactionHistory> TransactionsHistory { get; set; }
    }
}
