using System;

/* Write a program to print the first 100 members of
 * the sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21,
 * 34, 55, 89, 144, 233, 377, …
 */

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("Fibonacci sequence.");
        decimal previousMember = 0;
        decimal currentMember = 1;
        decimal nextMember = 0;

        Console.WriteLine(previousMember);
        Console.WriteLine(currentMember);

        for (int i = 1; i < 99; i++)
        {
            nextMember = previousMember + currentMember;
            Console.WriteLine(nextMember);
            previousMember = currentMember;
            currentMember = nextMember;
        }
    }
}