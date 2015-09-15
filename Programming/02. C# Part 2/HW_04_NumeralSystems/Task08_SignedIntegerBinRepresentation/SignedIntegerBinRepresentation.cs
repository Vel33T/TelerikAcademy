using System;

/* Write a program that shows the binary representation
 * of given 16-bit signed integer number (the C# type short).
 */

class SignedIntegerBinRepresentation
{
    static string BinaryRepresentation(short number)
    {
        string temp = "";
        for (int i = 0; i < 16; i++)
        {
            temp = ((number >> i) & 1) + temp;
        }
        return temp;
    }

    static void Main()
    {
        short number = short.Parse(Console.ReadLine());
        Console.WriteLine(BinaryRepresentation(number));
    }
}
