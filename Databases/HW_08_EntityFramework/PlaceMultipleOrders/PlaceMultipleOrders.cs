namespace PlaceMultipleOrders
{
    using System;
    using System.Data;
    using System.Data.Entity.Infrastructure;
    using System.Transactions;
    using EntityFrameworkHomework.Models;

    public class PlaceMultipleOrders
    {
        public static void Main()
        {
            var retries = 3;

            Order[] orders =
            {
                new Order()
                {
                    OrderDate = DateTime.Now,
                    ShipCountry = "Bulgaria"
                },
                new Order()
                {
                    OrderDate = DateTime.Now,
                    ShipCountry = "Romania"
                },
                new Order()
                {
                    OrderDate = DateTime.Now,
                    ShipCountry = "Austria"
                },
            };


            if (InsertOrders(retries, orders))
            {
                Console.WriteLine("Orderes added successfully.");
            }
            else
            {
                Console.WriteLine(
                    "The operation could not be completed in {0} tries.",
                    retries);
            }
        }

        private static bool InsertOrders(int retries, Order[] orders)
        {
            var success = false;
            var dbContext = new NorthwindEntities();

            // Retry loop.
            for (int i = 0; i < retries; i++)
            {
                using (var transaction = new TransactionScope())
                {
                    try
                    {
                        foreach (var order in orders)
                        {
                            dbContext.Orders.Add(order);
                        }

                        dbContext.SaveChanges();
                        transaction.Complete();
                        success = true;
                        break;
                    }
                    catch (Exception ex)
                    {
                        if (ex.GetType() != typeof(UpdateException))
                        {
                            Console.WriteLine(
                                "An error occured. The operation cannot be retried. {0}",
                                ex.Message);

                            break;
                        }
                    }
                }
            }

            if (success)
            {
                ((IObjectContextAdapter)dbContext)
                    .ObjectContext.AcceptAllChanges();
            }

            dbContext.Dispose();
            return success;
        }
    }
}
