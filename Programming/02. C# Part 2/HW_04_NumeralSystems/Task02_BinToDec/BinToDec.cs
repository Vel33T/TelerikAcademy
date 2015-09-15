using System;

/* Write a program to convert binary numbers to their decimal representation.
 */

class BinToDec
{
    static void Main()
    {
        string bin = Console.ReadLine();
        int dec = 0;
        foreach (char digit in bin)
        {
            dec <<= 1;
            if (digit == '1')
            {
                dec ^= 1;
            }
        }
        Console.WriteLine(dec);
    }
}
