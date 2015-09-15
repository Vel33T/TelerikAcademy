using System;

class InCircleInRectangle
{
    static void Main()
    {
        Console.Write("Enter point coordinates. \r\nx = ");
        string str1 = Console.ReadLine();
        int x = int.Parse(str1);

        Console.Write("y = ");
        string str2 = Console.ReadLine();
        int y = int.Parse(str2);

        bool inCircle = ((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 9;
        bool inRectangle = ((x >= -1) && ( x <=5)) && ((y >= -1) && (y <= 1));

        if ((inCircle == true) && (inRectangle == false))
        {
            Console.WriteLine("The point is inside the circle and outside the rectangle.");
        }
        else if ((inCircle == true) && (inRectangle == true))
        {
            Console.WriteLine("The point is inside the circle,but inside the rectangle.");
        }
        else if ((inCircle == false) && (inRectangle == true))
        {
            Console.WriteLine("The point is inside the rectangle, but outside the circle.");
        }
        else
        {
            Console.WriteLine("The point is probably inside a bar and outside this shit :))");
        }
    }
}

