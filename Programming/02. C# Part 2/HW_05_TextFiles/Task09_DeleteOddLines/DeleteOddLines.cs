using System;
using System.IO;
using System.Collections.Generic;

/* Write a program that deletes from given text file all
 * odd lines. The result should be in the same file.
 */

class DeleteOddLines
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../TextFile1.txt");
        List<string> lines = new List<string>();
        using (input)
        {
            int counter = 1;
            string line = input.ReadLine();
            while (line != null)
            {
                if (counter % 2 != 1)
                {
                    lines.Add(line);
                }
                counter++;
                line = input.ReadLine();
            }
        }
        StreamWriter output = new StreamWriter("../../TextFile1.txt");
        using (output)
        {
            foreach (string line in lines)
            {
                output.WriteLine(line);
            }
        }
    }
}
