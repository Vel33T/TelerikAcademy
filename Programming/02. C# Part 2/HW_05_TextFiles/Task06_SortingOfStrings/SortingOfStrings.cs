using System;
using System.IO;
using System.Collections.Generic;

/* Write a program that reads a text file containing a
 * list of strings, sorts them and saves them to another
 * text file. Example:
 *  Ivan	  --> 	George
 *  Peter	  -->	Ivan
 *  Maria	  -->	Maria
 *  George	  -->	Peter
 */

class SortingOfStrings
{
    static void Main()
    {
        StreamReader input = new StreamReader("../../TextFile1.txt");
        StreamWriter output = new StreamWriter("../../TextFile2.txt");
        using (input)
        {
            string tempLine = input.ReadLine();
            List<string> lines = new List<string>();
            while (tempLine != null)
            {
                lines.Add(tempLine);
                tempLine = input.ReadLine();
            }
            lines.Sort();
            using (output)
            {
                foreach (string line in lines)
                {
                    output.WriteLine(line);
                }
            }
        }
    }
}