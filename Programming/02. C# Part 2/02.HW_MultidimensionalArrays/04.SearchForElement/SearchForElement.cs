using System;

/* Write a program, that reads from the console an
 * array of N integers and an integer K, sorts the array
 * and using the method Array.BinSearch() finds
 * the largest number in the array which is ≤ K.
 */

    class SearchForElement
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(array);

            int largestNumber = 0;
            if (array[0] < k)
            {
                int elementIndex = Array.BinarySearch(array, k);
                if (elementIndex >= 0)
                {
                    largestNumber = array[elementIndex];
                }
                else
                {
                    largestNumber = array[~elementIndex - 1];
                }
                Console.WriteLine(largestNumber);
            }
            else
            {
                Console.WriteLine("There is no such number");
            }

        }
    }
