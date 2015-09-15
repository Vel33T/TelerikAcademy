namespace ManipulateCustomers
{
    using System;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public static class DataAccessUtils
    {
        public static void InsertCustomer(Customer customer)
        {
            using (var dbContext = new NorthwindEntities())
            {
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
        }

        public static void ModifyCustomer(Customer customer)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var obsoleteCustomer = dbContext
                    .Customers
                    .Where(x => x.CustomerID == customer.CustomerID)
                    .FirstOrDefault();

                if (obsoleteCustomer == null)
                {
                    throw new ArgumentNullException("No such user in database!");
                }

                dbContext.Customers.Remove(obsoleteCustomer);
                dbContext.Customers.Add(customer);
                dbContext.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerID)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var customer = dbContext
                    .Customers
                    .Where(x => x.CustomerID == customerID)
                    .FirstOrDefault();

                if (customer == null)
                {
                    throw new ArgumentNullException(
                        "No such user in database!");
                }

                dbContext.Customers.Remove(customer);
                dbContext.SaveChanges();
            }
        }
    }
}
