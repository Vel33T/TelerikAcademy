namespace SubsetsWithoutRepetition
{
    using System;

    class Program
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            string[] elements = { "test", "rock", "fun" };
            string[] subset = new string[k];

            GetSubsets(elements, subset, 0, 0);
        }

        private static void GetSubsets(string[] elements, string[] subset, int arrIndex, int startIndex)
        {
            if (arrIndex == subset.Length)
            {
                Console.WriteLine("(" + String.Join(" ", subset) + ")");
                return;
            }

            for (int currentElement = startIndex; currentElement < elements.Length; currentElement++)
            {
                subset[arrIndex] = elements[currentElement];
                GetSubsets(elements, subset, arrIndex + 1, currentElement + 1);
            }
        }
    }
}
