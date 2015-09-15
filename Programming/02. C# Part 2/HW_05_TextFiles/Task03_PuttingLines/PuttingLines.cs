using System;
using System.IO;

/* Write a program that reads a text file and inserts line
 * numbers in front of each of its lines. The result
 * should be written to another text file.
 */

class PuttingLines
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../TextFile1.txt");
        StreamWriter output = new StreamWriter("../../TextFile2.txt");
        using (input)
        {
            string line = input.ReadLine();
            int lineCounter = 0;
            using (output)
            {
                while (line != null)
                {
                    lineCounter++;
                    output.WriteLine("Line {0,3}: {1}", lineCounter, line);
                    line = input.ReadLine();
                }
            }
        }
    }
}
