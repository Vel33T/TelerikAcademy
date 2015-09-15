using System;

/* Write a method that calculates the number of
 * workdays between today and given date, passed as
 * parameter. Consider that workdays are all days from
 * Monday to Friday except a fixed list of public
 * holidays specified preliminary as array.
 */

class Workdays
{
    static int WorkDaysCounting(int days, DateTime[] holidays, DateTime start)
    {
        int workDays = 0;
        for (int i = 0; i < days; i++)
        {
            start = start.AddDays(1);
            if (start.DayOfWeek != DayOfWeek.Sunday && start.DayOfWeek != DayOfWeek.Saturday)
            {
                workDays++;
                for (int j = 0; j < holidays.Length; j++)
                {
                    if (start == holidays[j])
                    {
                        workDays--;
                        break;
                    }
                }
            }
        }
        return workDays;
    }

    static void Main()
    {
        Console.Write("Enter end date in format DD/MM/YYYY: ");
        string[] endDate = Console.ReadLine().Split('/');
        int day = int.Parse(endDate[0]),
            month = int.Parse(endDate[1]),
            year = int.Parse(endDate[2]);

        DateTime start = DateTime.Today;
        DateTime end = new DateTime(year, month, day);
        int days = Math.Abs((end - start).Days);

        DateTime[] holidays =
        {
            new DateTime(2013, 3, 13),
            new DateTime(2013, 4, 25),
            new DateTime(2013, 5, 1),
            new DateTime(2013, 6, 9),
            new DateTime(2013, 8, 18),
            new DateTime(2013, 2, 15),
            new DateTime(2013, 2, 5)
        };
        Console.WriteLine(WorkDaysCounting(days, holidays, start));
    }
}