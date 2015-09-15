using System;

/* Write a method that checks if the element at given
 * position in given array of integers is bigger than its
 * two neighbors (when such exist).
 */

class BiggerThanNeighbours
{
    //static int[] array = { 1 };
    //static int[] array = { 56, 3, 34, 6, 75, 4, 345, 34, 67, 34, 3 };
    static int[] array = { 2, 3, 4, 5, 43, 65, 643, 27, 3, 3, 2, 3 };

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
        int position = int.Parse(Console.ReadLine());
        bool result = false;
        if (position - 1 < 0 || position + 1 > array.Length - 1)
        {
            Console.WriteLine("There is only one or none at all neighbours at this position!");
        }
        else
        {
            result = Check(position);
            Console.WriteLine(result ? "The element at this position is bigger than its neighbours." : "The element at this position is NOT bigger than its neighbours.");
        }
    }
}
