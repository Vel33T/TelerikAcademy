using System;

/* Write a program that reads the radius r of a circle
 * and prints its perimeter and area. */

class CirlePerimeterAndArea
{
    static void Main()
    {
        Console.Write("Enter the radius of a circle: ");
        double radius = double.Parse(Console.ReadLine());

        double perimeter = 2 * radius * Math.PI;
        double area = radius * radius * Math.PI;

        Console.WriteLine("The circle's perimeter is {0} and its area is {1}", perimeter, area);
    }
}

