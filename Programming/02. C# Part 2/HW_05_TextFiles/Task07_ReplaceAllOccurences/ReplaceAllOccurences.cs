using System;
using System.IO;

/* Write a program that replaces all occurrences of the
 * substring "start" with the substring "finish" in a text
 * file. Ensure it will work with large files (e.g. 100 MB).
 */

 class ReplaceAllOccurences
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
                    line = line.Replace("start", "finish");
                    output.WriteLine(line);
                    line = input.ReadLine();
                }
            }
        }
    }
}
