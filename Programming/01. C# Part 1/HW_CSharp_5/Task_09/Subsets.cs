using System;

/* We are given 5 integer numbers. Write a program
 * that checks if the sum of some subset of them is 0.
 * Example: 3, -2, 1, 1, 8 -> 1+1-2=0.
 */

class Subsets
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());
        Console.Write("Enter the fourth number: ");
        int d = int.Parse(Console.ReadLine());
        Console.Write("Enter the fifth number: ");
        int e = int.Parse(Console.ReadLine());

        // Subsets with 2 elements
        if (a + b == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", a, b);
        if (a + c == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", a, c);
        if (a + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", a, d);
        if (a + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", a, e);
        if (b + c == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", b, c);
        if (b + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", b, d);
        if (b + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", b, e);
        if (c + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", c, d);
        if (c + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", c, e);
        if (d + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1}", d, e);

        // Subsets with 3 elements
        if (a + b + c == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", a, b, c);
        if (a + b + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", a, b, d);
        if (a + b + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", a, b, e);
        if (a + c + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", a, c, d);
        if (a + c + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", a, c, e);
        if (a + d + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", a, d, e);
        if (b + c + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", b, c, d);
        if (b + c + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", b, c, e);
        if (b + d + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", b, d, e);
        if (c + d + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2}", c, d, e);

        //Subsets with 4 elements
        if (a + b + c + d == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2} , {3}", a, b, c, d);
        if (a + b + c + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2} , {3}", a, b, c, e);
        if (b + c + d + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2} , {3}", b, c, d, e);

        //Subset with 5 elements
        if (a + b + c + d + e == 0)
            Console.WriteLine("The subset with sum 0 is: {0} , {1} , {2} , {3} , {4}", a, b, c, d, e);
    }
}

