namespace SubsetsWithRepetitions
{
    using System;

    class SubsetsWithRepetitions
    {
        static void Main()
        {
            int k = int.Parse(Console.ReadLine());
            string[] elements = { "hi", "a", "b" };
            string[] subset = new string[k];

            GetSubsets(elements, subset, 0);
        }

        private static void GetSubsets(string[] elements, string[] subset, int arrIndex)
        {
            if (arrIndex == subset.Length)
            {
                Console.WriteLine("(" + String.Join(" ", subset) + ")");
                return;
            }

            for (int currentElement = 0; currentElement < elements.Length; currentElement++)
            {
                subset[arrIndex] = elements[currentElement];
                GetSubsets(elements, subset, arrIndex + 1);
            }
        }
    }
}
