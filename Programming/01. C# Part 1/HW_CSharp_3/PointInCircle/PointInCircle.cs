using System;

class PointInCircle
{
    static void Main()
    {
        Console.Write("Enter point coordinates. \r\nx = ");
        string str1 = Console.ReadLine();
        int x = int.Parse(str1);

        Console.Write("y = ");
        string str2 = Console.ReadLine();
        int y = int.Parse(str2);

        bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 5;

        Console.WriteLine(inCircle ? "The point is withit the circle!" : "The point is outside the circle!");
    }
}
