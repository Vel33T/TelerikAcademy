using System;

/* Write a program that reads a number and prints it
 * as a decimal number, hexadecimal number,
 * percentage and in scientific notation. Format
 * the output aligned right in 15 symbols.
 */

class DifferentFormatting
{
    static void Main()
    {
        float number = float.Parse(Console.ReadLine());
        Console.WriteLine("{0,15}", number);
        Console.WriteLine("{0,15:X}", (int)number);
        Console.WriteLine("{0,15:P}", number/100);
        Console.WriteLine("{0,15:E}", number);
    }
}
