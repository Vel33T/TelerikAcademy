using System;

/* Write a program that finds the biggest of three
 * integers using nested if statements.
 */


class FindBiggestOf3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        if (first >= second)
        {
            if (first >= third)
                Console.WriteLine("The biggest number is: {0}", first);     // we still get the biggest number if some of the integers are equal
            else
                Console.WriteLine("The biggest number is: {0}", third);
        }
        else
        {
            if (second >= third)
                Console.WriteLine("The biggest number is: {0}", second);
            else
                Console.WriteLine("The biggest number is: {0}", third);
        }
    }
}
