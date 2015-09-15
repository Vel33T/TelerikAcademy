/* Write a program that prints an isosceles triangle of
 * 9 copyright symbols ©. Use Windows Character
 * Map to find the Unicode code of the © symbol.
 * Note: the © symbol may be displayed incorrectly.
 */

using System.Text;
using System;

class CopyrightTriangle
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        char copyright = '\u00A9';
        //int n = int.Parse(Console.ReadLine());
        int n = 3;

        // A little bit messy loop :)
        for (int i = 0; i < n; i++)
        {
            for (int j = n - 2; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < i * 2 + 1; j++)
            {
                Console.Write(copyright);
            }

            Console.WriteLine();
        }
        Console.WriteLine();

        // You can always do it manually
        Console.WriteLine("  {0}", copyright);
        Console.WriteLine(" {0}{0}{0}", copyright);
        Console.WriteLine("{0}{0}{0}{0}{0}", copyright);

        Console.WriteLine();

        //or with a single WriteLine
        Console.WriteLine("  {0}\n {0}{0}{0}\n{0}{0}{0}{0}{0}", copyright);

        Console.WriteLine();

        //or maybe like that
        for (int i = 1; i <= 3; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(copyright);
            }
            Console.WriteLine();
        }
        for (int i = 2; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(copyright);
            }
            Console.WriteLine();
        }
    }
}

