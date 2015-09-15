using System;

/* Write a program that finds the index of given
 * element in a sorted array of integers by using the
 * binary search algorithm (find it in Wikipedia).
 */

class BinarySearch
{
    static int BinSearch(int[] array, int key, int min, int max)
    {
        
        if (min > max)
        {
            return -1;
        }
        else
        {
            int mid = (min + max) / 2;

            if (array[mid] > key)
            {
                return BinSearch(array, key, min, mid - 1);
            }
            else if (array[mid] < key)
            {
                return BinSearch(array, key, mid + 1, max);
            }
            else
            {
                return mid;
            }
        }
    }

    static void Main()
    {
        int[] arr = { 1, 2, 3, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //Array.Sort(arr);

        int element = int.Parse(Console.ReadLine());

        int result = BinSearch(arr, element, 0, arr.Length - 1);

        if (result >= 0)
        {
            Console.WriteLine("The number is at index: {0}", result);
        }
        else
        {
            Console.WriteLine("There is no such number in the array.");
        }
    }
}
