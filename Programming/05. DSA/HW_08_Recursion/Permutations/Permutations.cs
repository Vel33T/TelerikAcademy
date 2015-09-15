namespace Permutations
{
    using System;

    class Permutations
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] permutation = new int[n];
            bool[] used = new bool[n];

            GetPermutations(permutation, used, 0);
        }

        private static void GetPermutations(int[] permutation, bool[] used, int arrIndex)
        {
            if (arrIndex == permutation.Length)
            {
                Console.WriteLine("{" + String.Join(", ", permutation) + "}");
                return;
            }

            for (int i = 1; i <= permutation.Length; i++)
            {
                if (used[i - 1] == false)
                {
                    permutation[arrIndex] = i;
                    used[i - 1] = true;
                    GetPermutations(permutation, used, arrIndex + 1);
                    used[i - 1] = false;
                }
            }
        }
    }
}