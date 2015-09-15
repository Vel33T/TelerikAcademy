using System;
using System.Linq;

namespace DivisibleBy7And3
{
    class Tests
    {
        static void Main(string[] args)
        {
            // Fast and lame filling of array for numbers to test
            int[] numbers = new int[300];
            for (int i = 0; i < 300; i++)
            {
                numbers[i] = i;
            }

            Console.WriteLine("Ordered by Lambda!");
            var approvedNumbersLambda = numbers.Where(x => x % 21 == 0);

            foreach (var number in approvedNumbersLambda)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            Console.WriteLine("Ordered by LINQ!");
            var approvedNumbersLINQ =
                from number in numbers
                where number % 21 == 0
                select number;

            foreach (var number in approvedNumbersLINQ)
            {
                Console.WriteLine(number);
            }
        }
    }
}
