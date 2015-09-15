/* Declare an integer variable and assign it with the
 * value 254 in hexadecimal format. Use Windows
 * Calculator to find its hexadecimal representation.
 */

using System;

class Hexadecimal
{
    static void Main()
    {
        int hexNumber = 0xFE;
        Console.WriteLine("The decimal number {0} is equal to {0:X} in hexadecimal", hexNumber);
    }
}

