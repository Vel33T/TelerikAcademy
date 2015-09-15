namespace DubplicateNorthwindDatabase
{
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Text;
    using EntityFrameworkHomework.Models;

    public class DubplicateNorthwindDatabase
    {
        public static void Main()
        {
            using (var dbContext = new NorthwindEntities())
            {
                var createQuery = "CREATE DATABASE NorthwindTwin";
                dbContext.Database.ExecuteSqlCommand(createQuery);

                var generatedScript = ((IObjectContextAdapter)dbContext)
                    .ObjectContext.CreateDatabaseScript();
                var fillQuery = "USE NorthwindTwin " + generatedScript;
                dbContext.Database.ExecuteSqlCommand(fillQuery);
            }
        }
    }
}
