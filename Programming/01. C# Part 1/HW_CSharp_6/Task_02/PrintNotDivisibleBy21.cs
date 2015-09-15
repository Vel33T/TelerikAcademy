using System;

/* Write a program that prints all the numbers from 1
 * to N, that are not divisible by 3 and 7 at the same
 * time
 */

class PrintNotDivisibleBy21
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if ((i % 21 != 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}