using System;
using System.Globalization;
using System.Text.RegularExpressions;

/* Write a program that extracts from a given text all
 * dates that match the format DD.MM.YYYY. Display
 * them in the standard date format for Canada.
 */

class ExtractingDates
{
    static void Main()
    {
        string dates = @"I was born at 14.06.1980. My sister was born at 3.7.1984. " +
            @"In 5/1999 I graduated my high school. The law says (see section 7.3.12) that we are " +
            @"allowed to do this (section 7.4.2.9)";
        DateTime date;
        System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-CA");
        foreach (Match item in Regex.Matches(dates, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date);
            }
        }
    }
}
