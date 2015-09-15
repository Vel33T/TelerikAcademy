using System;

/* Write a program that reads a number N and
 * calculates the sum of the first N members of the
 * sequence of Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34,
 * 55, 89, 144, 233, 377, …
 */

class SumOfFirstNFibonacciMembers
{
    static void Main()
    {
        Console.Write("Fibonacci sequence. Enter N: ");
        int n = int.Parse(Console.ReadLine());

        decimal previousMember = 0;
        decimal currentMember = 1;
        decimal nextMember = 0;
        decimal sum = 1;
        
        for (int i = 1; i < n - 1; i++)
        {
            nextMember = previousMember + currentMember;
            sum += nextMember;
            previousMember = currentMember;
            currentMember = nextMember;
        }

        Console.WriteLine("The sum of the first {0} members is : {1}", n, sum);
    }
}