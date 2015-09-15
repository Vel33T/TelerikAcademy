using System;
using System.IO;

/* Write a program that reads a text file and prints on the console its odd lines.
 */

class PrintingOddLines
{
    static void Main()
    {
        StreamReader reader = new StreamReader("../../TestFile.txt");
        using (reader)
        {
            int lineCounter = 0;
            string line = reader.ReadLine();
            while (line != null)
            {
                lineCounter++;
                if (lineCounter % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                line = reader.ReadLine();
            }
        }
    }
}
