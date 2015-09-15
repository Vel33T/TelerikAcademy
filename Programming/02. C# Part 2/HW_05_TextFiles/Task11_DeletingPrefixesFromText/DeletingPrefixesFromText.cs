using System;
using System.IO;
using System.Text.RegularExpressions;

/* Write a program that deletes from a text file all
 * words that start with the prefix "test". Words
 * contain only the symbols 0...9, a...z, A…Z, _.
 */


class DeletingPrefixesFromText
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../TextFile1.txt");
        StreamWriter output = new StreamWriter("../../TextFile2.txt");
        using (input)
        {
            string line = input.ReadLine();
            using (output)
            {
                while (line != null)
                {
                    line = Regex.Replace(line, @"\btest\w*\b", "");
                    output.WriteLine(line);
                    line = input.ReadLine();
                }
            }
        }
    }
}