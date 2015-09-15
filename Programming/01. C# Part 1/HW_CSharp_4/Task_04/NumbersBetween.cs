using System;

/* Write a program that reads two positive integer
 * numbers and prints how many numbers p exist
 * between them such that the reminder of the division
 * by 5 is 0 (inclusive). Example: p(17,25) = 2. */

class NumbersBetween
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        int second = int.Parse(Console.ReadLine());

        int counter = 0;

        if (first < second)
        {
            for (int i = first; i <= second; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
        }
        else if (first > second)
        {
            for (int i = second; i <= first; i++)
            {
                if (i % 5 == 0)
                {
                    counter++;
                }
            }
        }
        else
        {
            Console.WriteLine("The numbers are equal.");
        }

        Console.WriteLine("There are {0} numbers", counter);
    }
}

