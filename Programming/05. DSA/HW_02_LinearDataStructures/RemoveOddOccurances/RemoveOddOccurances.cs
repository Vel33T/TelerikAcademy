using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveOddOccurances
{
    class RemoveOddOccurances
    {
        static void Main()
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2 };
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

            numbers.RemoveAll(x => occurances[x] % 2 != 0);
            
            Console.WriteLine("Result");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write(numbers[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
