using System;

/* Write a program that finds the maximal sequence of equal elements in an array.
 * Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
 */

class MaxSequenceEqualElements
{
    static void Main()
    {
        int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };

        int len = 1;
        int bestLen = 0;
        int bestStart = 0;

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

        for (int i = 0; i < bestLen; i++)
        {
            Console.Write("{0} ", bestStart);
        }
    }
}
