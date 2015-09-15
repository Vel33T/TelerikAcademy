using System;

/* Write a program that reads the coefficients a, b and c
 * of a quadratic equation ax2+bx+c=0 and solves it
 * (prints its real roots).
 */

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Solving quadratic equation ax2+bx+c=0");
        Console.Write("Enter a: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter c: ");
        double c = double.Parse(Console.ReadLine());

        double descriminant = (b * b) - (4 * a * c);

        if (descriminant > 0)
        {
            double rootOne = (-b + Math.Sqrt(descriminant)) / 2;
            double rootTwo = (-b - Math.Sqrt(descriminant)) / 2;
            Console.WriteLine("There are two real roots.");
            Console.WriteLine("First root is: {0}", rootOne);
            Console.WriteLine("Second root is: {0}", rootTwo);
        }
        else if (descriminant == 0)
        {
            double rootOne = -(b / (2 * a));
            Console.WriteLine("There is one real root: {0}", rootOne);
        }
        else
        {
            Console.WriteLine("There are no real roots.");
        }
    }
}

