using System;

/* Write an if statement that examines two integer
 * variables and exchanges their values if the first one
 * is greater than the second one.
 */

class Exchange
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        if (a > b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
        }

        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

