using System;

/* Write a program to convert decimal numbers to their hexadecimal representation.
 */

class DecimalToHexadecimal
{
    static string GetString(int a)  //Todo: Test if this method is fast enough
    {
        if (a >= 10)
        {
            return ((char)('A' - 10 + a)).ToString();
        }
        else
        {
            return ((char)('0' + a)).ToString();
        }
    }

    static void Main()
    {
        int dec = int.Parse(Console.ReadLine());
        string hex = "";

        while (dec > 0)
        {
            hex = GetString(dec % 16) + hex;
            dec /= 16;
        }

        Console.WriteLine(hex);
    }

}
