using System;

/* Write a program that finds the most frequent
 * number in an array. Example:
 * {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 */

class MostFrequentNumber
{
    static void Main()
    {
        int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        Array.Sort(arr);
        int bestLen = 0;
        int bestStart = 0;
        int len = 1;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == arr[i + 1])
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = arr[i];
                }
            }
            else
            {
                len = 1;
            }
        }
        Console.WriteLine("{0}({1} times)", bestStart, bestLen);
    }
}
