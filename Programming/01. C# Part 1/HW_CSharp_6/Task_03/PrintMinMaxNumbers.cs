using System;

/* Write a program that reads from the console a
 * sequence of N integer numbers and returns the
 * minimal and maximal of them.
 */

class PrintMinMaxNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want to compare: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter number 1 : ");
        int current = int.Parse(Console.ReadLine());

        int min = current;
        int max = current;

        for (int i = 2; i <= n; i++)
        {
            Console.Write("Enter number {0} : ", i);
            current = int.Parse(Console.ReadLine());

            if (current > max)
            {
                max = current;
            }

            if (current < min)
            {
                min = current;
            }
        }
        Console.WriteLine("Minimum number is : {0}", min);
        Console.WriteLine("Maximum number is : {0}", max);
    }
}