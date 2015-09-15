using System;

/* Write a program to convert decimal numbers to their binary representation.
 */

class DecimalToBinary
{
    static void Main(string[] args)
    {
        uint dec = uint.Parse(Console.ReadLine());
        string bin = "";
        // In a lot of these programs I use concatenation of strings
        // but I decided to do it like that because the number of processes are few.
        while (dec > 0)
        {
            bin = (dec % 2) + bin;
            dec /= 2;
        }
        Console.WriteLine(bin);
    }
}
