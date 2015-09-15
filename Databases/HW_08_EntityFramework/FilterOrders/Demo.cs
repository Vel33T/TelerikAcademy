namespace FilterOrders
{
    using System;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public class Demo
    {
        public static void Main()
        {
            var orders = DataAccessUtils.FilterOrdersByRegionAndPeriod(
                null,
                new DateTime(1996, 6, 1),
                new DateTime(1996, 12, 31));

            foreach (var order in orders)
            {
                Console.WriteLine(
                    "OrderID: {0}; OrderDate: {1:dd.MM.yyyy}; ShipRegion: {2}",
                    order.OrderID,
                    order.OrderDate,
                    order.ShipRegion);
            }
        }
    }
}
