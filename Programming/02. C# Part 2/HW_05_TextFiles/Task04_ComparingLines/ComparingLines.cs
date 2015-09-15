using System;
using System.IO;

/*Write a program that concatenates two text files into another text file.
 */

class ComparingLines
{
    static void Main()
    {
        StreamReader input1 = new StreamReader("../../TextFile1.txt");
        StreamReader input2 = new StreamReader("../../TextFile2.txt");
        string lineText1 = "";
        string lineText2 = "";
        int linesSame = 0;
        int linesDifferent = 0;

        using (input1)
        {
            using (input2)
            {
                lineText1 = input1.ReadLine();
                lineText2 = input2.ReadLine();
                while (lineText1 != null) //Assuming they have equal number of lines
                {
                    if (lineText1 == lineText2)
                    {
                        linesSame++;
                    }
                    else
                    {
                        linesDifferent++;
                    }
                    lineText1 = input1.ReadLine();
                    lineText2 = input2.ReadLine();
                }
            }
        }
        Console.WriteLine("Same lines: " + linesSame);
        Console.WriteLine("Different lines: "+ linesDifferent);
    }
}