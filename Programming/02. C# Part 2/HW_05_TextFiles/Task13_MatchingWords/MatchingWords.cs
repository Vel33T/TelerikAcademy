using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Security;

/* Modify the solution of the previous problem to
 * replace only whole words (not substrings).
 */

class MatchingWords
{
    static void Main()
    {
        try
        {
            string[] words = File.ReadAllLines("../../words.txt");
            int[] values = new int[words.Length];
            StreamReader input = new StreamReader("../../TextFile1.txt");
            StreamWriter output = new StreamWriter("../../TextFile2.txt");
            using (input)
            {
                string line = input.ReadLine();
                string currWord = "";
                while (line != null)
                {
                    for (int i = 0; i < words.Length; i++)
                    {
                        currWord = "\\b" + words[i] + "\\b";
                        values[i] += Regex.Matches(line, currWord).Count;
                    }
                    line = input.ReadLine();
                }
            }

            Array.Sort(values, words);

            using (output)
            {
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    output.WriteLine("The word: {0,-10} repeats: {1,-2} times", words[i], values[i]);
                }
            }
        }
        catch (FileNotFoundException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (IOException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (SecurityException e)
        {
            Console.Error.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}