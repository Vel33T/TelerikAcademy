using System;
using System.IO;
using System.Text.RegularExpressions;

/* Modify the solution of the previous problem to
 * replace only whole words (not substrings).
 */

class ReplaceOnlyWords
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
                    line = Regex.Replace(line, @"\bstart\b", "finish");
                    output.WriteLine(line);
                    line = input.ReadLine();
                }
            }
        }
    }
}
