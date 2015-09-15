using System;

/* Write a program that finds the sequence of maximal
 * sum in given array. Example:
 * {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}
 * Can you do it with only one loop (with single scan
 * through the elements of the array)?
 */

// It can be done with only one loop by using "Kadane's algorithm"

class MaxSumSequence
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };
        int max = arr[0],
            maxEnd = arr[0],
            begin = 0,
            beginTemp = 0,
            currSequence = 1,
            longSequence = 1;

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] + maxEnd > arr[i])
            {
                maxEnd += arr[i];
                currSequence++;
            }
            else
            {
                maxEnd = arr[i];
                beginTemp = i;
                currSequence = 1;
            }

            if (maxEnd > max)
            {
                max = maxEnd;
                longSequence = currSequence;
                begin = beginTemp;
            }
        }

        Console.WriteLine("The maximum sum is: {0}", max);
        Console.Write("And the sequence is: ");
        for (int i = begin; i < begin + longSequence; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
        Console.WriteLine();
    }
}
