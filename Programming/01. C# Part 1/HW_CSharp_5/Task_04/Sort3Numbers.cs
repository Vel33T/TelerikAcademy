using System;

/* Sort 3 real values in descending order using nested if
 * statements.
 */

class Sort3Numbers
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int first = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int second = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int third = int.Parse(Console.ReadLine());

        if (first > second)
        {
            if (first > third)
            {
                if (second > third)
                    Console.WriteLine("{0} -> {1} -> {2}", first, second, third);
                else        // third > second
                    Console.WriteLine("{0} -> {1} -> {2}", first, third, second);
            }
            else            // third > first
                Console.WriteLine("{0} -> {1} -> {2}", third, first, second);

        }
        else if (second > third)
        {
            if (first > third)
                Console.WriteLine("{0} -> {1} -> {2}", second, first, third);
            else            // third > first
                Console.WriteLine("{0} -> {1} -> {2}", second, third, first);
        }
        else
            Console.WriteLine("{0} -> {1} -> {2}", third, second, first);
    }
}

