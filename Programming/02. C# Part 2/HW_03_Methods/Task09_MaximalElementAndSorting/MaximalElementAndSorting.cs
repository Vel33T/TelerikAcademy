using System;

/* Write a method that return the maximal element in
 * a portion of array of integers starting at given index.
 * Using it write another method that sorts an array in
 * ascending / descending order.
 */

class MaximalElementAndSorting
{
    static int[] array = { 2, 4, 5, 7, 9, 8, 7, 6, 4, 0, 5, 0, 5, 3 };
    static bool ascending = true;

    static void Swap(int a, int b)
    {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }

    static int MaxElement(int currentIndex)
    {
        int max = currentIndex;
        if (ascending)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
        }
        else
        {
            for (int i = currentIndex; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
        }
        return max;
    }

    static void Sorting()
    {
        if (ascending)
        {
            for (int i = array.Length - 1; i > 0; i--)
            {
                Swap(i, MaxElement(i));
            }
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                Swap(i, MaxElement(i));
            }
        }
    }

    static void PrintArray()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        // True for Ascending, False for Descending
        // It can be made more interactive :))
        Sorting();
        PrintArray();

        ascending = false;
        Sorting();
        PrintArray();
    }
}
