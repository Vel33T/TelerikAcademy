using System;

/* Write a program that reads two numbers N and K
 * and generates all the variations of K elements
 * from the set [1..N]. Example:
 * N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
 */

class AllVariations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Variations(int[] arr, int index)
    {
        if (index == arr.Length)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                arr[index] = i;
                Variations(arr, index + 1);
            }
        }
    }

    static void Main()
    {
        int[] variations = new int[k];
        Variations(variations, 0);
    }
}
