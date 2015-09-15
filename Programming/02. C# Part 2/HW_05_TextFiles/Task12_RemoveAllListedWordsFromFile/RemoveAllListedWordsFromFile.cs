using System;
using System.IO;
using System.Text.RegularExpressions;

/* Modify the solution of the previous problem to
 * replace only whole words (not substrings).
 */

class RemoveAllListedWordsFromFile
{
    static void Main()
    {
        try
        {
            StreamReader input = new StreamReader("../../TextFile1.txt");
            StreamWriter output = new StreamWriter("../../TextFile2.txt");
            using (input)
            {
                string line = input.ReadLine();
                string words = "\\b(" + String.Join("|", File.ReadAllLines("../../words.txt")) + ")\\b";
                using (output)
                {
                    while (line != null)
                    {
                        line = Regex.Replace(line, words, "Emptyyyyyyy"); //Added this "Empty" for the testing only
                        output.WriteLine(line);
                        line = input.ReadLine();
                    }
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
        catch (Exception e)
        {
            Console.Error.WriteLine(e.Message);
        }
    }
}