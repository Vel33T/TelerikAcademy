namespace TestingQueryToList
{
    using System;
    using System.Linq;
    using TelerikAcademy.Models;

    public static class TestingQueryToList
    {
        public static void Main()
        {
            using (var dbContext = new TelerikAcademyEntities())
            {
                // QueryAllEmployeesWithoutOptimization(dbContext);
                QueryAllEmployeesWithOptimization(dbContext);
            }
        }

        private static void QueryAllEmployeesWithoutOptimization(TelerikAcademyEntities dbContext)
        {
            var allEmployees = dbContext.Employees.ToList()
                .Select(e => e.Address).ToList()
                .Select(e => e.Town).ToList()
                .Where(e => e.Name == "Sofia").ToList();
        }

        private static void QueryAllEmployeesWithOptimization(TelerikAcademyEntities dbContext)
        {
            var allEmployees = dbContext.Employees
                .Select(e => e.Address)
                .Select(e => e.Town)
                .Where(e => e.Name == "Sofia").ToList();
        }
    }
}
