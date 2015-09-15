namespace FilterOrders
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public static class DataAccessUtils
    {
        public static ICollection<Order> FilterOrdersByRegionAndPeriod(string region, DateTime periodFrom, DateTime periodTo)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var orders = dbContext
                    .Orders
                    .Where(x => x.OrderDate >= periodFrom)
                    .Where(x => x.OrderDate <= periodTo);

                if (region == null)
                {
                    orders = orders
                        .Where(x => x.ShipRegion == null);
                }
                else
                {
                    orders = orders
                        .Where(x => x.ShipRegion == region);
                }

                return orders.ToList();
            }
        }
    }
}
