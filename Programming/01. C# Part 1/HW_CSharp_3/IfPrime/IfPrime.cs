using System;

class IfPrime
    {
        static void Main()
        {
            Console.Write("Enter the number: ");
            string str = Console.ReadLine();

            int number = int.Parse(str);
            int maxDivider = (int) Math.Sqrt(number);
            bool prime = true;

            for (int divider = 2; divider < maxDivider; divider++)
            {
                if (number % divider == 0)
                {
                    prime = false;
                    break; 
                }
            }

            if (prime)
            {
                Console.WriteLine("The number {0} is prime.", number);
            }
            else
            {
                Console.WriteLine("The number {0} is Not prime.", number);
            }
        }
    }
