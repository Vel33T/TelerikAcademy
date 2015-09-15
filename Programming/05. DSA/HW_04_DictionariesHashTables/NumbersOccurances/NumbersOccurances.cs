using System;
using System.Linq;
using System.Collections.Generic;

namespace NumbersOccurances
{
    class NumbersOccurances
    {
        static void Main()
        {
            List<double> numbers = new List<double>() { 3, 4, 4, -2.5, 3, 3, 4, 3, -2.5 };
            Dictionary<double, int> occurances = new Dictionary<double, int>();

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

            foreach (var pair in occurances)
            {
                Console.WriteLine("{0} -> {1} times", pair.Key, pair.Value);
            }
        }
    }
}