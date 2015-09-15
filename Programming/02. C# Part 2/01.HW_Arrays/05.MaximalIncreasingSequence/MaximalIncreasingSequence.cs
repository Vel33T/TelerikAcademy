using System;

/* Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

class MaximalIncreasingSequence
{
    static void Main()
    {
        int[] arr = { 3, 2, 3, 4, 2, 2, 4 };

        int len = 1;
        int bestLen = 0;
        int bestStart = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                len++;
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = i - (len - 2);
                }
            }
            else
            {
                len = 1;
            }
        }

        for (int i = 0; i < bestLen; i++)
        {
            Console.Write("{0} ", arr[bestStart + i]);
        }
    }
}