using System;

/* Write a program that reads from the console a
 * positive integer number N (N < 20) and outputs a
 * matrix like the following:
 */

class PrintMatrix
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int y = i; y < n + i; y++)
            {
                Console.Write("{0,2}", y);
            }

            Console.WriteLine();
        }
    }
}