using System;

/* Write a program to convert hexadecimal numbers to their decimal representation.
 */

class HexadecimalToDecimal
{
    static int GetNumber(char a)
    {
        if (a >= 'A')
        {
            return (int)(a - 'A' + 10);
        }
        else
        {
            return (int)(a - '0');
        }
    }

    static void Main()
    {
        string hex = Console.ReadLine();
        int dec = 0;
        int count = 1;

        for (int i = hex.Length - 1; i >= 0; i--)
        {
            dec += GetNumber(hex[i]) * count;
            count <<= 4;
        }
        Console.WriteLine(dec);
    }
}
