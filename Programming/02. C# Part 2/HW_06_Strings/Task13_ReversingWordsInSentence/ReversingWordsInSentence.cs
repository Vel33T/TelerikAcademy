using System;
using System.Text;

/* Write a program that reverses the words in given sentence.
 * Example: "C# is not C++, not PHP and not Delphi!"
 * --> "Delphi not and PHP, not C++ not is C#!".
 */
// This program keeps the same punctuation as listed in the example.

class ReversingWordsInSentence
{
    static StringBuilder Building(string[] arrStr, string[] punctuation)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < arrStr.Length; i++)
        {
            result.Append(arrStr[i]).Append(punctuation[i]);
            if (arrStr.Length - 1 != i)
            {
                result.Append(" ");
            }
        }
        return result;
    }

    static void GetPunctuation(string[] arrStr, string[] punctuation)
    {
        for (int i = 0; i < arrStr.Length; i++)
        {
            int temp = arrStr[i].Length;
            if (arrStr[i].EndsWith(","))
            {
                punctuation[i] = ",";
                arrStr[i] = arrStr[i].Substring(0, temp - 1);
            }
            else if (arrStr[i].EndsWith(";"))
            {
                punctuation[i] = ";";
                arrStr[i] = arrStr[i].Substring(0, temp - 1);
            }
            else if (arrStr[i].EndsWith(":"))
            {
                punctuation[i] = ":";
                arrStr[i] = arrStr[i].Substring(0, temp - 1);
            }
            else if (arrStr[i].EndsWith("."))
            {
                punctuation[i] = ".";
                arrStr[i] = arrStr[i].Substring(0, temp - 1);
            }
            else if (arrStr[i].EndsWith("!"))
            {
                punctuation[i] = "!";
                arrStr[i] = arrStr[i].Substring(0, temp - 1);
            }
            else if (arrStr[i].EndsWith("?"))
            {
                punctuation[i] = "?";
                arrStr[i] = arrStr[i].Substring(0, temp - 1);
            }
        }
    }

    static void Main()
    {
        string sentence = "C# is not C++, not PHP and not Delphi!";
        string[] arrStr = sentence.Split(' '); // The splitting is only by empty spaces
        string[] punctuation = new string[arrStr.Length]; // Using this to get after which word I must put the right punctuation
        GetPunctuation(arrStr, punctuation); // Removing the words ending with some kind of punctuation and putting this punctuation in another array at the same index
        Array.Reverse(arrStr);
        Console.WriteLine(Building(arrStr, punctuation)); // At the end we put all parts together ;)
    }
}