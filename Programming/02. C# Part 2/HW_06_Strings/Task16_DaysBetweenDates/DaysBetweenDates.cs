using System;

/* Write a program that reads two dates in the
 * format: day.month.year and calculates the
 * number of days between them. 
 */

class DaysBetweenDates
{
    static void Main()
    {
        Console.Write("Enter the first date: ");
        string firstDate = Console.ReadLine();

        Console.Write("Enter the second date: ");
        string secondDate = Console.ReadLine();

        Console.WriteLine("Distance: {0} days", (DateTime.Parse(secondDate) - DateTime.Parse(firstDate)).TotalDays);
    }
}
