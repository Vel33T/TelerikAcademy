namespace NestedLoops
{
    using System;

    class NestedLoops
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] variation = new int[n];

            GetNestedLoops(variation, 0);
        }

        private static void GetNestedLoops(int[] variation, int arrIndex)
        {
            if (arrIndex == variation.Length)
            {
                Console.WriteLine(String.Join(" ", variation));
                return;
            }

            for (int currentNumber = 1; currentNumber <= variation.Length; currentNumber++)
            {
                variation[arrIndex] = currentNumber;
                GetNestedLoops(variation, arrIndex + 1);
            }
        }
    }
}
