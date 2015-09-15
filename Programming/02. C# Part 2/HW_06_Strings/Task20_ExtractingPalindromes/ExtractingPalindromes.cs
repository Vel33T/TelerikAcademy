using System;

/* Write a program that extracts from a given text all
 * palindromes, e.g. "ABBA", "lamal", "exe".
 */

class ExtractingPalindromes
{
    static void Main()
    {
        string text = "Petyr ABBA plete. Prez tri lamal preplita. Pleti exe Petre. PletelP.";
        char[] separators = { ' ', ',', '.', '!', '\n', '\r' };
        string[] words = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);

        foreach (string word in words)
        {
            bool palindrome = true;
            for (int i = 0; i < (word.Length / 2); i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                {
                    palindrome = false;
                    break;
                }
            }
            if (palindrome)
            {
                Console.WriteLine(word);
            }
        }
    }
}
