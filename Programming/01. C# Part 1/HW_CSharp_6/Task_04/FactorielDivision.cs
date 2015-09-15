using System;

/* Write a program that calculates N!/K! for given N
 * and K (1<N<K).
 */

class FactorielDivision
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        long nFactoriel = 1;
        long kFactoriel = 1;

        if ((n > 1) && (k > n))
        {
            int i = 0;
            for (i = 2; i <= n; i++)
            {
                nFactoriel *= i;
            }

            //using already computed nFactoriel to complete the computing of kFactoriel
            //because K > N
            kFactoriel = nFactoriel;

            for (int y = i; y <= k; y++)
            {
                kFactoriel *= y;
            }

            double result = nFactoriel / (kFactoriel * 1.0);

            Console.WriteLine("The result of N!/K! is: {0}", result);
        }
        else
        {
            Console.WriteLine("Wrong input! (1<N<K)");
        }
    }
}