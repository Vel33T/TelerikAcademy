using System;

/* Write a program that calculates N!*K! / (K-N)! for
 * given N and K (1<N<K).
 */

class FactorielComputations
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Enter K: ");
        int k = int.Parse(Console.ReadLine());

        int kMinusN = k - n;

        long nFactoriel = 1;
        long kFactoriel = 1;
        long kMinusNFactoriel = 1;

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

            for (int x = 2; x <= kMinusN; x++)
            {
                kMinusNFactoriel *= x;
            }

            double result = (nFactoriel * kFactoriel * 1.0) / kMinusNFactoriel;

            Console.WriteLine("The result of N!*K! / (K-N)! is: {0}", result);
        }
        else
        {
            Console.WriteLine("Wrong input! (1<N<K)");
        }
    }
}