/* Find online more information about ASCII
 * (American Standard Code for Information
 * Interchange) and write a program that prints
 * the entire ASCII table of characters on the console.
 */

using System.Text;
using System;

class ASCIITable
{
    static void Main(string[] args)
    {
        Console.WriteLine("  Dec  Hex  Oct  Char");
        for (int i = 0; i <= 256; i++)
        {
            Console.WriteLine("{0,5}{1,5:X}{2,5}{3,5}", i, i, Convert.ToString(i,8), (char)i);
        }
    }
}
