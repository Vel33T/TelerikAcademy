using System;

/* Write a program that, for a given two integer
 * numbers N and X, calculates the sum
 * S = 1 + 1!/X + 2!/X2 + … + N!/XN
 */

class CalculationFactorialSum
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter X: ");
        int x = int.Parse(Console.ReadLine());

        decimal sum = 1.0m;
        decimal factorial = 1;
        decimal xToPower = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            xToPower *= x;
            sum += factorial / xToPower;
        }

        Console.WriteLine("The result is : {0}", sum);
    }
}

