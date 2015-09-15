using System;

/* Write a program that creates an array containing all
 * letters from the alphabet (A-Z). Read a word from the
 * console and print the index of each of its letters in the array.
 */

class IndexesOfLettersInWord
{
    // Using BinSearch method that I did for the previous homework :)
    static int BinSearch(char[] array, char key, int min, int max)
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

    static void Main()
    {
        // I will use an array with length 27 because I want 'A' to be at index 1
        char[] array = new char[27];
        for (int i = 1; i < 27; i++)
        {
            array[i] = (char)('A' + i - 1);         //Filling the array with letters
        }
        string word = Console.ReadLine().ToUpper(); //Making all the letters large

        Console.WriteLine();
        foreach (char letter in word)               //printing the result
        {                                           //by accessing the method BinSearch
            Console.Write("{0} ",BinSearch(array, letter, 1, 26));
        }
        Console.WriteLine();
    }
}
