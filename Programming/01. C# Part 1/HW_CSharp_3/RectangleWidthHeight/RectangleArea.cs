using System;

class RectangleArea
{
    static void Main()
    {
        Console.Write("Enter Rectangle's width: ");
        string str = Console.ReadLine();
        int width = int.Parse(str);

        Console.Write("Enter Rectangle's height: ");
        string str2 = Console.ReadLine();
        int height = int.Parse(str2);

        Console.WriteLine("Rectangle's area is {0}", width * height);
    }
}

