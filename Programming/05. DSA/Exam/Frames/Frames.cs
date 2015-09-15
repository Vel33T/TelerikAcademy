namespace Frames
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    class Frames
    {
        static int[,] pairs;

        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            pairs = new int[n, 2];

            for (int i = 0; i < n; i++)
            {
                string[] numbers = Console.ReadLine().Split(' ');
                int number1 = int.Parse(numbers[0]);
                int number2 = int.Parse(numbers[1]);
                if (number1 > number2)
                {
                    pairs[i, 0] = number2;
                    pairs[i, 1] = number1;
                }
                else
                {
                    pairs[i, 1] = number2;
                    pairs[i, 0] = number1;
                }
            }

            if (pairs[0,0] == pairs[0, 1])
            {
                Console.WriteLine(1);
                Console.WriteLine("({0}, {1})", pairs[0, 0], pairs[0, 1]);
            }
            else if (pairs[0,0] < pairs[0, 1])
            {
                Console.WriteLine(2);
                Console.WriteLine("({0}, {1})", pairs[0, 0], pairs[0, 1]);
                Console.WriteLine("({0}, {1})", pairs[0, 1], pairs[0, 0]);
            }
            else
            {
                Console.WriteLine(2);
                Console.WriteLine("({0}, {1})", pairs[0, 1], pairs[0, 0]);
                Console.WriteLine("({0}, {1})", pairs[0, 0], pairs[0, 1]);
                Console.WriteLine();
            }
        }
    }
}
