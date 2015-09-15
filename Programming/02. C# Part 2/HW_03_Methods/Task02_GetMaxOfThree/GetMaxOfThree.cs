using System;

/* Write a method GetMax() with two parameters that
 * returns the bigger of two integers. Write a program
 * that reads 3 integers from the console and prints the
 * biggest of them using the method GetMax().
 */

class GetMaxOfThree
{
    static int GetMax(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }


    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int third = int.Parse(Console.ReadLine());

        int biggest = GetMax(GetMax(first, second), third);

        Console.WriteLine("The biggest number is: {0}", biggest);
    }
}
