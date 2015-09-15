using System;

/* Write a program that finds the greatest of given 5
 * variables.
 */

class BiggestOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        Console.Write("Enter fourth number: ");
        int fourth = int.Parse(Console.ReadLine());

        Console.Write("Enter fifth number: ");
        int fifth = int.Parse(Console.ReadLine());

        int biggest = first;

        if (biggest < second)
        {
            biggest = second;
        }

        if (biggest < third)
        {
            biggest = third;
        }

        if (biggest < fourth)
        {
            biggest = fourth;
        }

        if (biggest < fifth)
        {
            biggest = fifth;
        }

        Console.WriteLine("The biggest number is: {0}", biggest);
    }
}

