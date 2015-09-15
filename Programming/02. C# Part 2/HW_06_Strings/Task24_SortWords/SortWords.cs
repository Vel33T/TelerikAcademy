using System;

/* Write a program that reads a list of words,
 * separated by spaces and prints the list in an
 * alphabetical order.
 */

class SortWords
{
    static void Main()
    {
        string text = "write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one";
        string[] words = text.Split(' ');

        Array.Sort(words);

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }
}
