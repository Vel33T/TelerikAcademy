using System;
using System.Linq;
using System.Collections.Generic;

namespace ReverseViaStack
{
    class ReverseViaStack
    {
        static void Main()
        {
            Stack<int> numbers = new Stack<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                numbers.Push(int.Parse(input));
            }

            Console.WriteLine("Reversed");

            int numbersLength = numbers.Count;

            for (int i = 0; i < numbersLength; i++)
            {
                Console.WriteLine(numbers.Pop());
            }
        }
    }
}
