using System;
using System.Linq;

namespace FindMajorant
{
    class FindMajorant
    {
        static void Main()
        {
            int[] numbers = { 2, 3, 2, 3, 2, 3, 4, 3, 3 };

            int? majorityElement = null;
            int stack = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (stack == 0)
                {
                    majorityElement = numbers[i];
                }

                if (numbers[i] == majorityElement)
                {
                    stack++;
                }
                else
                {
                    stack--;
                }
            }

            int count = numbers.Count(x => (x == majorityElement));

            if (!(count > (numbers.Length / 2)))
            {
                majorityElement = null;
            }

            Console.WriteLine(majorityElement);
        }
    }
}
