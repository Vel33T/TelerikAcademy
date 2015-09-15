using System;
using System.Linq;
using System.Collections.Generic;

namespace SortList
{
    class SortList
    {
        static void Main()
        {
            List<int> numbers = new List<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                numbers.Add(int.Parse(input));
            }

            numbers.Sort();

            Console.WriteLine("Sorted increasing order");
            int numbersLength = numbers.Count;

            for (int i = 0; i < numbersLength; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}