using System;

/* Write a program that compares two char arrays
 * lexicographically (letter by letter).
 */

class LexicographicalCharCompare
{
    static void Main()
    {
        char[] array1 = new char[] { 'V', 'a', 'n', 'k', 'a' };
        char[] array2 = new char[] { 'V', 'a', 'n', 'e' };

        int minLength = array1.Length;
        if (array1.Length > array2.Length)
        {
            minLength = array2.Length;
        }

        byte whichIsFirst = 0;
        for (int i = 0; i < minLength; i++)
        {
            if (array1[i] < array2[i])
            {
                whichIsFirst = 1;
                break;
            }
            else if (array1[i] > array2[i])
            {
                whichIsFirst = 2;
                break;
            }
        }

        switch (whichIsFirst)
        {
            case 1:
                Console.WriteLine("array1 is first.");
                Console.WriteLine("array2 is second.");
                break;

            case 2:
                Console.WriteLine("array2 is first.");
                Console.WriteLine("array1 is second.");
                break;

            case 0:
                if (array1.Length == array2.Length)
                {
                    Console.WriteLine("The arrays are equal.");
                }
                else if (array1.Length > array2.Length)
                {
                    Console.WriteLine("array2 is first.");
                    Console.WriteLine("array1 is second.");
                }
                else
                {
                    Console.WriteLine("array1 is first.");
                    Console.WriteLine("array2 is second.");
                }
                break;
        }
    }
}
