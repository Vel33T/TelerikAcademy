using System;
using System.Globalization;

/* Write a program that reads a date and time given
 * in the format: day.month.year hour:minute:second
 * and prints the date and time after 6 hours and
 * 30 minutes (in the same format) along with the
 * day of week in Bulgarian.
 */

class GivenDatePlus6HoursAnd30Minutes
{
    static void Main()
    {
        Console.WriteLine("Enter date and time in 'day.month.year hour:minute:second' format.");
        string inputDate = "3.02.2013 21:38:00";
        //string inputDate = Console.ReadLine();

        DateTime result = DateTime.Parse(inputDate);
        result = result.AddHours(6.5);

        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG");
        string day = result.ToString("dddd");
        Console.WriteLine(day);
        Console.WriteLine(result);
    }
}
