using System;

/* Write a method that adds two positive integer
 * numbers represented as arrays of digits (each array
 * element arr[i] contains a digit; the last digit is
 * kept in arr[0]). Each of the numbers that will be
 * added could have up to 10 000 digits.
 */

class AddingOfIntegers
{
    static int[] Add(int[] first, int[] second)
    {
        int[] temp = new int[Math.Max(first.Length, second.Length) + 1];
        
        int min = Math.Min(first.Length, second.Length);
        int remainder = 0;

        for (int i = 0; i < min; i++)
        {
            temp[i] = (first[i] + second[i] + remainder) % 10;
            remainder = (first[i] + second[i] + remainder) / 10;
        }
        if (first.Length > min)
        {
            for (int i = min; i < first.Length; i++)
            {
                temp[i] = (first[i] + remainder) % 10;
                remainder = (first[i] + remainder) / 10;
            }
        }
        else
        {
            for (int i = min; i < second.Length; i++)
            {
                temp[i] = (second[i] + remainder) % 10;
                remainder = (second[i] + remainder) / 10;
            }
        }
        temp[temp.Length - 1] = remainder;
        return temp;
    }

    static void Main()
    {
        //int[] first = { 2, 4, 5, 7, 9, 8, 7, 6, 4, 0, 5, 0, 5, 3 };
        //int[] second = { 8, 3, 2, 4, 7, 3, 1, 9 };
        int[] first = { 5, 5, 5, 5 , 5};
        int[] second = { 5, 5, 5, 5, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9, 9 };

        int[] result = Add(first, second);

        //This is just for checking if I done it right
        //It is not specified what we should do with the result, so I leave it like that.
        for (int i = result.Length - 1; i >= 0 ; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}
