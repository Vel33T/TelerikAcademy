using System;

/* Write a program that gets two numbers from the
 * console and prints the greater of them. Don’t use if
 * statements. 
 */

class PrintGreaterWithoutIf
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter first number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("The greater number is: ");
        Console.WriteLine(first > second ? first : second);
    }
}

