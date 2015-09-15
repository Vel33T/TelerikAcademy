namespace ATMDatabase.Client
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using System.Transactions;
    using ATMDatabase.Models;
    using ATMDatabase.Client.Data;
    using ATMDatabase.Client.Data.Migrations;

    public static class Client
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ATMContext, Configuration>());

            Console.WriteLine("Before");
            ListAcounts();

            var cardNumber = "1234567890";
            var amount = 5500m;
            var pin = "1234";
            var success = false;

            using (var dbContext = new ATMContext())
            {
                // Force Initialization
                // Comment seed once records are inserted
                dbContext.Database.Initialize(true);

                success = TryWithdraw(dbContext, cardNumber, amount, pin);
            }

            Console.WriteLine("Withdraw {0}", success ? "succeeded" : "failed");
            Console.WriteLine("After");
            ListAcounts();

        }

        public static bool TryWithdraw(ATMContext dbContext, string cardNumber, decimal amount, string PIN)
        {
            var success = false;

            var transactionOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.RepeatableRead };
            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, transactionOptions))
            {
                var cardQuery =
                    from c in dbContext.CardAccounts
                    where c.CardNumber == cardNumber
                    select c;

                var card = cardQuery.FirstOrDefault();

                if (card != null &&
                    card.CardPIN == PIN &&
                    card.CardCash >= amount)
                {
                    card.CardCash -= amount;
                    success = true;
                    scope.Complete();
                }
            }

            if (success)
            {
                RecordWithdraw(dbContext , cardNumber, amount);

                dbContext.SaveChanges();
                return true;
            }

            return false;
        }

        public static void RecordWithdraw(ATMContext dbContext, string cardNumber, decimal ammount)
        {
            var transactionOptions = new TransactionOptions() { IsolationLevel = IsolationLevel.RepeatableRead };
            using (var scope = new TransactionScope(TransactionScopeOption.RequiresNew, transactionOptions))
            {
                var newRecord = new TransactionHistory()
                {
                    TransactionDate = DateTime.Now,
                    Ammount = ammount,
                    CardNumber = cardNumber
                };

                dbContext.TransactionsHistory.Add(newRecord);
                scope.Complete();
            }

        }

        public static void ListAcounts()
        {
            using (var dbContext = new ATMContext())
            {
                foreach (var account in dbContext.CardAccounts)
                {
                    Console.WriteLine("Account ID: {0}, Amount: {1}", account.Id, account.CardCash);
                }
            }
        }
    }
}
