using System;
using System.Linq;
using System.Collections.Generic;

namespace RemoveAllNegativeNumbers
{
    class RemoveAllNegativeNumbers
    {
        static void Main()
        {
            LinkedList<int> numbers = new LinkedList<int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                {
                    break;
                }

                numbers.AddLast(int.Parse(input));
            }

            var node = numbers.First;
            while (node != null)
            {
                var next = node.Next;
                if (node.Value < 0)
                {
                    numbers.Remove(node);
                }
                node = next;
            }

            Console.WriteLine(string.Join(" -> ", numbers));
        }
    }
}