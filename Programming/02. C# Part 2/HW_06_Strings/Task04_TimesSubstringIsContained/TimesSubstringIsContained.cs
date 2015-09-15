using System;

/* Write a program that finds how many times a 
 * substring is contained in a given text (perform
 * case insensitive search).
 * Example: The target substring is "in". The text is as follows:
 */

class TimesSubstringIsContained
{
    static int Checking(string text, string match)
    {
        int count = 0;
        int matchLength = match.Length;
        for (int i = 0; i <= text.Length - matchLength; i++)
        {
            if (text.Substring(i, matchLength) == match)
            {
                count++;
            }
        }
        return count;
    }

    static void Main()
    {
        string text = "We are living in an yellow submarine. We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        text = text.ToLower();
        string match = Console.ReadLine();
        match = match.ToLower();
        Console.WriteLine("The result is: {0}", Checking(text, match));
    }
}
