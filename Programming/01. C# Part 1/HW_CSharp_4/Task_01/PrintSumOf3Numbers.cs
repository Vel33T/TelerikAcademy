using System;

/* Write a program that reads 3 integer numbers
 * from the console and prints their sum. */

class PrintSumOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        Console.WriteLine("The sum of the three numbers is: {0}", first + second + third);
    }
}