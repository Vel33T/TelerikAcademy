using System;

/*Write a program that prints to the console which day
 * of the week is today. Use System.DateTime.
 */

class DayOfWeek
{
    static void Main()
    {
        Console.WriteLine("Today is {0}.", DateTime.Today.DayOfWeek);
        // Just playing arround
        Console.WriteLine("Tomorrow will be {0}", DateTime.Today.AddDays(1).DayOfWeek);
        Console.WriteLine("Yesterday it was {0}", DateTime.Today.AddDays(-1).DayOfWeek);
    }
}
