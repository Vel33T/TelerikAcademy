using System;

/*Write a program that finds all prime numbers in the
 * range [1...10 000 000]. Use the sieve of Eratosthenes
 * algorithm (find it in Wikipedia).
 */


class AllPrimeNumbers
{
    static void Main()
    {
        bool[] array = new bool[10000001];  //by default all indexes are false
        for (int i = 2; i * i < array.Length; i++)
        {
            if (!array[i])
            {
                for (int j = i * i; j < array.Length; j += i)
                {
                    array[j] = true;
                }
            }
        }

        for (int i = 2; i < array.Length; i++)
        {
            if (!array[i])
            {
                Console.WriteLine(i);
            }
        }
    }
}
