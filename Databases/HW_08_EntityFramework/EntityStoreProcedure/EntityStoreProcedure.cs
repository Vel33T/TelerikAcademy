using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EntityFrameworkHomework.Models;
using System.Threading;

namespace EntityStoreProcedure
{
    public class EntityStoreProcedure
    {
        public static void Main(string[] args)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var totalIncome = GetTotalIncomes(
                    "Pavlova, Ltd.",
                    new DateTime(1990, 1, 1),
                    new DateTime(2000, 1, 1));

                Console.WriteLine(totalIncome);
            }
        }

        public static decimal? GetTotalIncomes(string supplierName, DateTime? startDate, DateTime? endDate)
        {
            using (var dbContext = new NorthwindEntities())
            {
                var totalIncome = dbContext
                    .usp_GetTotalIncome(supplierName, startDate, endDate)
                    .First();

                return totalIncome;
            }
        }
    }
}
