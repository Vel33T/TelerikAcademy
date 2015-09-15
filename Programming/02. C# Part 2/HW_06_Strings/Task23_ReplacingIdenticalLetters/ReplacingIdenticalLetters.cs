using System;
using System.Text.RegularExpressions;

/*Write a program that reads a string from the
 * console and replaces all series of consecutive
 * identical letters with a single one. Example:
 * "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".
 */

class ReplacingIdenticalLetters
{
    static void Main()
    {
        string letters = "aaaaabbbbbcdddeeeedssaa";
        letters = Regex.Replace(letters, @"(\w)\1+", "$1");
        Console.WriteLine(letters);
    }
}
