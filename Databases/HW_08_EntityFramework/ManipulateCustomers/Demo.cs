namespace ManipulateCustomers
{
    using System;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public class Demo
    {
        public static void Main()
        {
            using (var dbContext = new NorthwindEntities())
            {
                var customer = new Customer()
                {
                    CustomerID = "ZAZA",
                    CompanyName = "Mad House LTD",
                    ContactName = "Mad Man",
                    ContactTitle = "Owner",
                };

                DataAccessUtils.InsertCustomer(customer);

                customer.Country = "Bulgaria";
                DataAccessUtils.ModifyCustomer(customer);

                DataAccessUtils.DeleteCustomer(customer.CustomerID);
            }
        }
    }
}
