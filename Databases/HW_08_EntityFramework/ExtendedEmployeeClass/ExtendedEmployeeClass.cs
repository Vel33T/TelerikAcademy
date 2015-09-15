namespace ExtendedEmployeeClass
{
    using System;
    using EntityFrameworkHomework.Models;

    public class ExtendedEmployeeClass
    {
        public static void Main()
        {
            // Check EmployeeExtension class in Models project
            using (var context = new NorthwindEntities())
            {
                var employee = context.Employees.Find(5);

                foreach (var territory in employee.CorrespondingTerritories)
                {
                    Console.WriteLine(
                        "Corresponding territories - {0}",
                        territory.TerritoryDescription);
                }
            }
        }
    }
}
