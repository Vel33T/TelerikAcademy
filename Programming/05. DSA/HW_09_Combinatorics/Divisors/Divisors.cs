namespace Divisors
{
    using System;

    //TODO: !!!--Not Finished--!!!
    class Divisors
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] digits = new string[n];

            for (int i = 0; i < n; i++)
            {
                digits[i] = Console.ReadLine();
            }

            GenerateAllPossibleNumbers(digits, 0);
        }

        private static void GenerateAllPossibleNumbers(string[] digits, int index)
        {
            if (index == digits.Length)
            {
                
            }
        }

        private static int CountDivisors(int number)
        {
            int count = 0;

            for (int i = 0; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
