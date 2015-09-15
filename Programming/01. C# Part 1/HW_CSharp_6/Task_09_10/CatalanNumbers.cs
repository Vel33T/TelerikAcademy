using System;
using System.Numerics;

/*Write a program to calculate the Nth Catalan
 * number by given N.
 */

class CatalanNumbers
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        BigInteger factorial = 1;
        BigInteger factorial2 = 1;
        BigInteger result = 0;

        for (int i = 1, y = (n + 1); i <= n; i++, y++)
        {
            factorial *= i;
            factorial2 *= y;
        }

        result = (factorial2 * factorial) / (((n + 1) * factorial) * factorial);

        Console.WriteLine("Catalan number {0} is: {1}", n, result);
    }
}