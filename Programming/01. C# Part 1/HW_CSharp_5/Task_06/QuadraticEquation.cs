using System;

/* Write a program that enters the coefficients a, b and
 * c of a quadratic equation
 * a*x2 + b*x + c = 0
 * and calculates and prints its real roots. Note that
 * quadratic equations may have 0, 1 or 2 real roots.
 */

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Solving quadratic equation here!!!");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        // d - Descriminant
        double d = (b * b) - (4 * a * c);

        if (d > 0)
        {
            double rootOne = (-b + Math.Sqrt(d)) / 2;
            double rootTwo = (-b - Math.Sqrt(d)) / 2;
            Console.WriteLine("There are two real roots.");
            Console.WriteLine("First root is: {0}", rootOne);
            Console.WriteLine("Second root is: {0}", rootTwo);
        }
        else if (d == 0)
        {
            double rootOne = -(b / (2 * a));
            Console.WriteLine("There is one real root: {0}", rootOne);
        }
        else
            Console.WriteLine("There are no real roots.");
    }
}

