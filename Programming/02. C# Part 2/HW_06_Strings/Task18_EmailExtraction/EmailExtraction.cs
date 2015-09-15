using System;
using System.Text.RegularExpressions;

/* Write a program for extracting all email addresses
 * from given text. All substrings that match the
 * format <identifier>@<host>…<domain> should
 * be recognized as emails.
 */

class EmailExtraction
{
    static void Main()
    {
        string text = "Onche@bonche schupeno@pironche.com ri.ba shtuka@mahai.se ot@tu.ka";

        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}
