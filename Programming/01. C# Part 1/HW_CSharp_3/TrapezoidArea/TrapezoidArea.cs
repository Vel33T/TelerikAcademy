using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.Write("Enter Trapezoid's side a: ");
        string str = Console.ReadLine();
        int a = int.Parse(str);

        Console.Write("Enter Trapezoid's side b: ");
        string str2 = Console.ReadLine();
        int b = int.Parse(str2);

        Console.Write("Enter Trapezoid's height: ");
        string str3 = Console.ReadLine();
        int height = int.Parse(str3);

        double area = ((a + b) / 2.0) * height;
        Console.WriteLine("Trapezoid's area is {0}", area);
    }
}

