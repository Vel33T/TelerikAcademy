using System;
using System.Text.RegularExpressions;

/* Write a program that extracts from a given text all sentences containing given word.
 */

class ExtractSentences
{
    static void Main()
    {
        string text = "We are living in a yellow submarine.We don't have anything else. Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
        string[] sentences = text.Split('.');
        string word = Console.ReadLine();
        foreach (string sentence in sentences)
        {
            if (Regex.Matches(sentence, ("\\b" + word + "\\b")).Count > 0)
            {
                Console.WriteLine((sentence + ".").Trim());
            }
        }
    }
}
