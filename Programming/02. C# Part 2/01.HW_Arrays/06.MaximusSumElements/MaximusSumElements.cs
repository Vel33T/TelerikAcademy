using System;

/* Write a program that reads two integer numbers N
 * and K and an array of N elements from the console.
 * Find in the array those K elements that have maximal sum.
 */

class MaximusSumElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] arr = new int[n];
        int highestSum = 0;
        int start = 0;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i <= n - k; i++)
        {
            sum = 0;
            for (int y = i; y < k + i; y++)
            {
                sum += arr[y];
            }
            if (sum > highestSum)
            {
                highestSum = sum;
                start = i;
            }
        }

        Console.WriteLine("The sum is: {0}", highestSum);
        for (int i = 0; i < k; i++)
        {
            Console.Write("{0} ", arr[start + i]);
        }
    }
}