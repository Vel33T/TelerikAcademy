using System;

/* Sorting an array means to arrange its elements in
 * increasing order. Write a program to sort an array.
 * Use the "selection sort" algorithm: Find the smallest
 * element, move it at the first position, find the
 * smallest from the rest, move it at the second position, etc.
 */

class SelectionSort
{
    static void Main()
    {
        int[] arr = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8, 23874, -34272, 0 };
        int minNumPossition = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            minNumPossition = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minNumPossition])
                {
                    minNumPossition = j;
                }
            }

            if (minNumPossition != i)
            {
                int temp = arr[i];
                arr[i] = arr[minNumPossition];
                arr[minNumPossition] = temp;
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("{0} ", arr[i]);
        }
    }
}
