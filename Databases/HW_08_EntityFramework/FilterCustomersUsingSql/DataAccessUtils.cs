namespace FilterCustomersUsingSql
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
                object[] param = { year, shippedTo };
                string query = "SELECT * " +
                    "FROM Orders o " +
                    "JOIN Customers c " +
                    "ON o.CustomerID = c.CustomerID " +
                    "WHERE YEAR(o.OrderDate) = {0} " + 
                    "AND o.ShipCountry = {1}";

                var customers = dbContext.Database.SqlQuery<Customer>(query, param);

                return customers.ToList();
            }
        }
    }
}
