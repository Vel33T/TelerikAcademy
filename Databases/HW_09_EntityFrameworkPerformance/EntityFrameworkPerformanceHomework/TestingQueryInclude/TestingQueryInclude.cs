namespace TestingQueryInclude
{
    using System;
    using System.Linq;
    using TelerikAcademy.Models;

    public static class TestingQueryInclude
    {
        public static void Main()
        {
            using (var dbContext = new TelerikAcademyEntities())
            {
                // ListEmployeesWithoutOptimization(dbContext);
                ListEmployeesWithOptimization(dbContext);
            }
        }

        private static void ListEmployeesWithoutOptimization(TelerikAcademyEntities dbContext)
        {
            foreach (var employee in dbContext.Employees)
            {
                Console.WriteLine(
                    "Employee: {0} {1}; Department {2}; Town: {3}",
                    employee.FirstName,
                    employee.LastName,
                    employee.Department.Name,
                    employee.Address.Town.Name);
            }
        }

        private static void ListEmployeesWithOptimization(TelerikAcademyEntities dbContext)
        {
            foreach (var employee in dbContext.Employees
                .Include("Department")
                .Include("Address.Town"))
            {
                Console.WriteLine(
                    "Employee: {0} {1}; Department {2}; Town: {3}",
                    employee.FirstName,
                    employee.LastName,
                    employee.Department.Name,
                    employee.Address.Town.Name);
            }
        }
    }
}
