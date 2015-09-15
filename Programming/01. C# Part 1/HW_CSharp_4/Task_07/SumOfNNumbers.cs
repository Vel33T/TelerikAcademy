using System;

/* Write a program that gets a number n and after that
 * gets more n numbers and calculates and prints their
 * sum.
 */

class SumOfNNumbers
{
    static void Main()
    {
        Console.Write("Enter how many numbers you want calculated: ");
        uint n = uint.Parse(Console.ReadLine());

        double sum = 0;
        double number = 0;
        for (uint i = 1; i <= n; i++)
        {
            Console.Write("Enter number {0}: ", i);
            number = double.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("The sum is: {0} ", sum);
    }
}
