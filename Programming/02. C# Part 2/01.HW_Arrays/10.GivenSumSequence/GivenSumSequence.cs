using System;

/* Write a program that finds in given array of integers
 * a sequence of given sum S (if present). Example:
 * {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}
 */

class GivenSumSequence
{
    static void Main()
    {
        int[] arr = { 4, 3, 1, 4, 2, 5, 8 };
        int s = int.Parse(Console.ReadLine());
        int tempSum = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            tempSum = 0;
            for (int j = i; j < arr.Length; j++)
            {
                tempSum += arr[j];
                if (tempSum == s)
                {
                    for (int y = i; y <= j; y++)
                    {
                        Console.Write("{0} ", arr[y]);
                    }
                    Console.WriteLine();
                    return;
                }
            }
        }
        Console.WriteLine("In the given array there is no sequence with sum: {0}.", s);
    }
}
