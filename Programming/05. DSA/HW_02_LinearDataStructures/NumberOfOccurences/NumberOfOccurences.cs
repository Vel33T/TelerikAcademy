using System;
using System.Linq;
using System.Collections.Generic;

namespace NumberOfOccurences
{
    class NumberOfOccurences
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
            Dictionary<int, int> occurances = new Dictionary<int, int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (!occurances.Keys.Contains(numbers[i]))
                {
                    occurances.Add(numbers[i], 1);
                }
                else
                {
                    occurances[numbers[i]]++;
                }
            }

            foreach (KeyValuePair<int, int> pair in occurances)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}
