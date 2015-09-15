using System;

/* Write a method that counts how many times given
 * number appears in given array. Write a test program
 * to check if the method is working correctly.
 */

public class NumberInArrayAppearances
{
    // For easier testing.
    public static int[] array = { 1, 2, 3, 4, 4, 3, 3, 3, 2, 3, 4, 5, 6, 7, 7, 7, 8, 9, 1 };

    public static int Check(int a)
    {
        int counter = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == a)
            {
                counter++;
            }
        }
        return counter;
    }

    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int result = Check(number);
        Console.WriteLine("In the given array the number {0} appears {1} times.", number, result);
    }
}
