using System;

/* Write a method that returns the index of the first
 * element in array that is bigger than its neighbors,
 * or -1, if there’s no such element.
 *  Use the method from the previous exercise.
 */

class FirstElementBiggerThanNeighbours
{
    //static int[] array = { 1, 2 };
    //static int[] array = { 56, 3, 34, 6, 75, 4, 2, 34, 67, 34, 3 };
    static int[] array = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 34 };

    static bool Check(int index)
    {
        if (array[index - 1] < array[index] && array[index] > array[index + 1])
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        int indexOfResult = -1;

        if (array.Length < 2)
        {
            Console.WriteLine(indexOfResult);
        }
        else
        {
            for (int i = 1; i < array.Length - 2; i++)
            {
                if (Check(i))
                {
                    indexOfResult = i;
                    break;
                }
            }
        }
        Console.WriteLine(indexOfResult);
    }
}
