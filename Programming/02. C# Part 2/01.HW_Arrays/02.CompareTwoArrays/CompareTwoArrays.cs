using System;

/* Write a program that reads two arrays from the
 * console and compares them element by element.
 */

class CompareTwoArrays
{
    static void Main()
    {
        Console.Write("Enter first array length: ");
        int len1 = int.Parse(Console.ReadLine());
        int[] array1 = new int[len1];
        for (int i = 0; i < len1; i++)
        {
            Console.Write("Enter element {0}: ", i);
            array1[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter second array length: ");
        int len2 = int.Parse(Console.ReadLine());
        int[] array2 = new int[len2];
        for (int i = 0; i < len2; i++)
        {
            Console.Write("Enter element {0}: ", i);
            array2[i] = int.Parse(Console.ReadLine());
        }

        bool result = true;
        if (len1 == len2)
        {
            for (int i = 0; i < len1; i++)
            {
                if (array1[i] != array2[i])
                {
                    result = false;
                    break;
                }
            }
        }
        else
        {
            result = false;
        }

        Console.WriteLine("Are the elements equal? {0}", result ? "Yes." : "No.");
    }
}
