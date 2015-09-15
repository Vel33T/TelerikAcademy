namespace OpenDifferentContexts
{
    using System;
    using System.Linq;
    using EntityFrameworkHomework.Models;

    public class OpenDifferentContexts
    {
        public static void Main()
        {
            using (var firstContext = new NorthwindEntities())
            using (var secondContext = new NorthwindEntities())
            {
                firstContext
                    .Customers
                    .Find("FOLKO")
                    .ContactName = "Svetlin";

                secondContext
                    .Customers
                    .Find("FOLKO")
                    .ContactName = "Nakov";

                firstContext.SaveChanges();
                secondContext.SaveChanges();
            }
        }
    }
}
