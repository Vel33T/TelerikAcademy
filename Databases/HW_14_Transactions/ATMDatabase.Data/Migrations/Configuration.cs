namespace ATMDatabase.Client.Data.Migrations
{
    using System.Data.Entity.Migrations;
    using ATMDatabase.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ATMContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ATMContext context)
        {
            context.CardAccounts.AddOrUpdate(x => x.CardNumber,
                new CardAccount() { CardCash = 10000, CardNumber = "1234567890", CardPIN = "1234" },
                new CardAccount() { CardCash = 5000, CardNumber = "0987654321", CardPIN = "4321" },
                new CardAccount() { CardCash = 2500, CardNumber = "2468013579", CardPIN = "2413" },
                new CardAccount() { CardCash = 1250, CardNumber = "1357924680", CardPIN = "1324" }
                );
        }
    }
}
