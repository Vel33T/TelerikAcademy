using System;

/* Write a program that reads two numbers N and K
 * and generates all the combinations of K distinct
 * elements from the set [1..N]. Example:
 * N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}
 */

class AllCombinations
{
    static int n = int.Parse(Console.ReadLine());
    static int k = int.Parse(Console.ReadLine());

    static void Combination(int[] arr, int index, int current)
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
            for (int i = current; i <= n; i++)
            {
                arr[index] = i;
                Combination(arr, index + 1, i + 1);
            }
        }
    }

    static void Main()
    {
        int[] variations = new int[k];
        Combination(variations, 0, 1);
    }
}