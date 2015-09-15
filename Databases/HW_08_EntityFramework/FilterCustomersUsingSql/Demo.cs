namespace FilterCustomersUsingSql
{
    using System;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public class Demo
    {
        public static void Main()
        {
            var customers = DataAccessUtils
                .FilterCustomersByOrders(1997, "Canada");

            foreach (var customer in customers)
            {
                Console.WriteLine(
                    "CustomerID: {0}; ContactName: {1}",
                    customer.CustomerID,
                    customer.ContactName);
            }
        }
    }
}
