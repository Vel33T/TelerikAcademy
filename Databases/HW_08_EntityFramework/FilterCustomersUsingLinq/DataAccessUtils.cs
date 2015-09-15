namespace FilterCustomersUsingLinq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public static class DataAccessUtils
    {
        public static ICollection<Customer> FilterCustomersByOrders(int year, string shippedTo)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var customers = dbContext
                    .Orders
                    .Where(x => x.OrderDate.Value.Year == 1997)
                    .Where(x => x.ShipCountry == "Canada")
                    .Select(x => x.Customer);

                return customers.ToList();
            }
        }
    }
}
