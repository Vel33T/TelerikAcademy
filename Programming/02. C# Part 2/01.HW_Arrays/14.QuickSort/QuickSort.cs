using System;

/* Write a program that sorts an s using
 * the quick sort algorithm (find it in Wikipedia).
 */


class QuickSort
{
    static int Partitioning(string[] array, int left, int right)
    {
        string strPivot = array[right];
        int p = left - 1;
        string temp = "";
        for (int i = left; i < right; i++)
        {
            if (string.Compare(array[i], strPivot) < 0)
            {
                p = p + 1;
                temp = array[p];
                array[p] = array[i];
                array[i] = temp;
            }
        }

        temp = array[p + 1];
        array[p + 1] = array[right];
        array[right] = temp;

        return p + 1;
    }

    static void QuickSorting(string[] array, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partitioning(array, left, right);

            QuickSorting(array, left, pivot - 1);
            QuickSorting(array, pivot + 1, right);
        }
    }

    static void Main()
    {
        string[] array = { "bc", "abcd", "xsa", "xspo", "yuas", "ad", "abc", "uyds" };

        QuickSorting(array, 0, array.Length - 1);

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}

