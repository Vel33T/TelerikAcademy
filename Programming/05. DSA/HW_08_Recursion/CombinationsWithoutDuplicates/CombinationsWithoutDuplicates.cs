namespace CombinationsWithoutDuplicates
{
    using System;

    class CombinationsWithoutDuplicates
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] combination = new int[k];

            GetCombinationsWithoutDuplicates(combination, 0, 1, n);
        }

        private static void GetCombinationsWithoutDuplicates(int[] combination, int arrIndex, int startNumber, int lastNumber)
        {
            if (arrIndex == combination.Length)
            {
                Console.WriteLine("(" + String.Join(" ", combination) + ")");
                return;
            }

            for (int i = startNumber; i <= lastNumber; i++)
            {
                combination[arrIndex] = i;
                GetCombinationsWithoutDuplicates(combination, arrIndex + 1, i + 1, lastNumber);
            }
        }
    }
}
