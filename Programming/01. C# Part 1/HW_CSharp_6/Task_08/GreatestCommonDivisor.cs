using System;

/* Write a program that calculates the greatest
 * common divisor (GCD) of given two numbers. Use
 * the Euclidean algorithm (find it in Internet).
 */

class GreatestCommonDivisor
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        while (first != 0 && second != 0)
        {
            if (first > second)
            {
                first %= second;
            }
            else
            {
                second %= first;
            }
        }

        if (first == 0)
        {
            Console.WriteLine("The greatest common divisor is: {0}", second);
        }
        else
        {
            Console.WriteLine("The greatest common divisor is: {0}", first);
        }
    }
}