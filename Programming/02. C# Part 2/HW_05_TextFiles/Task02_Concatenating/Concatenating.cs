using System;
using System.IO;

/*Write a program that concatenates two text files into another text file.
 */

class Concatenating
{
    static void Main()
    {
        StreamReader input1 = new StreamReader("../../TextFile1.txt");
        StreamReader input2 = new StreamReader("../../TextFile2.txt");
        StreamWriter output = new StreamWriter("../../TextFile3.txt");
        string result1 = "";
        string result2 = "";
        using (input1)
        {
            result1 = input1.ReadToEnd();
        }
        using (input2)
        {
            result2 = input2.ReadToEnd();
        }
        using (output)
        {
            output.WriteLine(result1);
            output.WriteLine(result2);
        }
    }
}
