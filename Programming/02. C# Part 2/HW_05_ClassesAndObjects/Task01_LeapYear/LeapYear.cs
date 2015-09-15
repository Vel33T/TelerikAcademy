using System;

/* Write a program that reads a year from the console
 * and checks whether it is a leap. Use DateTime.
 */

class LeapYear
{
    static void Main()
    {
        Console.WriteLine("Enter year: ");
        int year = int.Parse(Console.ReadLine());
        bool result = DateTime.IsLeapYear(year);
        Console.WriteLine(result ? "The year is leap" : "The year isn't leap");
    }
}
