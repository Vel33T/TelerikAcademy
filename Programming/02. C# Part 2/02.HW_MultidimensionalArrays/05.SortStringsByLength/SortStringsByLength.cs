using System;

/* You are given an array of strings. Write a method
 * that sorts the array by the length of its elements
 * (the number of characters composing them).
 */

    class SortStringsByLength
    {
        static void Main()
        {
            string[] stringArray = { "ads", "asdasd", "qweqweqweqw", "a", "sd", "asdas", "asdasdads", "asdasasd", "adsddasd" };
            int[] intArray = new int[stringArray.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                intArray[i] = stringArray[i].Length;
            }
            
            Array.Sort(intArray, stringArray);

            for (int i = 0; i < stringArray.Length; i++)
            {
                Console.WriteLine(stringArray[i]);
            }
        }
    }
