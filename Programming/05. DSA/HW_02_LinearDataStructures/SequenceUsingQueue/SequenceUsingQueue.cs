using System;
using System.Linq;
using System.Collections.Generic;

namespace SequenceUsingQueue
{
    class SequenceUsingQueue
    {
        static void Main()
        {
            List<int> results = new List<int>();
            Queue<int> numbers = new Queue<int>();

            Console.Write("Enter N: ");
            numbers.Enqueue(int.Parse(Console.ReadLine()));

            for (int i = 0; i < 50; i++)
            {
                int s = numbers.Dequeue();

                results.Add(s);

                numbers.Enqueue(s + 1);
                numbers.Enqueue(2 * s + 1);
                numbers.Enqueue(s + 2);
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
