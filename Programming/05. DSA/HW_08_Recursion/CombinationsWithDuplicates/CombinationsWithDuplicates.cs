namespace CombinationsWithDuplicates
{
    using System;

    class CombinationsWithDuplicates
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] combination = new int[k];

            GetCombinationsWithDuplicates(combination, 0, 1, n);
        }

        private static void GetCombinationsWithDuplicates(int[] combination, int arrIndex, int firstNumber, int lastNumber)
        {
            if (arrIndex == combination.Length)
            {
                Console.WriteLine("(" + String.Join(" ", combination) + ")");
                return;
            }

            for (int i = firstNumber; i <= lastNumber; i++)
            {
                combination[arrIndex] = i;
                GetCombinationsWithDuplicates(combination, arrIndex + 1, i, lastNumber);
            }
        }
    }
}
