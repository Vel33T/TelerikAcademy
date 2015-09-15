using System;
using System.Linq;
using System.Collections.Generic;

namespace PrintSumAndAverageOfSequence
{
    class PrintSumAndAverageOfSequence
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

                int parsedNumber = -1;

                if (int.TryParse(input, out parsedNumber) && parsedNumber > 0)
                {
                    numbers.Add(parsedNumber);
                }
                else
                {
                    Console.WriteLine("Invalid format! Try again :)");
                }
            }

            // I know that I can make my methods for sum and average
            // and it will be faster but in this case it doesn't matter :)
            Console.WriteLine("The sum is {0}", numbers.Sum());
            Console.WriteLine("The average is {0}", numbers.Average());
        }
    }
}
