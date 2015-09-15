using System;

/* *Write a program that sorts an array of integers
 * using the merge sort algorithm (find it in Wikipedia).
 */

class MergeSort
{
    static void DoMerging(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[50];
        int leftEnd = 0,
            tempPosition = 0,
            numberOfElements = 0;

        leftEnd = (mid - 1);
        tempPosition = left;
        numberOfElements = (right - left + 1);

        while ((left <= leftEnd) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
            {
                temp[tempPosition++] = numbers[left++];
            }
            else
            {
                temp[tempPosition++] = numbers[mid++];
            }
        }
        while (left <= leftEnd)
        {
            temp[tempPosition++] = numbers[left++];
        }

        while (mid <= right)
        {
            temp[tempPosition++] = numbers[mid++];
        }

        for (int i = 0; i < numberOfElements; i++)
        {
            numbers[right] = temp[right];
            right--;
        }

    }

    static void MergeSorting(int[] numbers, int left, int right)
    {
        int mid = 0;

        if (right > left)
        {
            mid = (right + left) / 2;
            MergeSorting(numbers, left, mid);
            MergeSorting(numbers, (mid + 1), right);

            DoMerging(numbers, left, (mid + 1), right);
        }

    }

    static void Main()
    {
        int[] numbers = { 2, 34, 56, 8, -6, 5, 6, -33, 8, 1 };

        MergeSorting(numbers, 0, numbers.Length - 1);

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
        Console.WriteLine();
    }
}