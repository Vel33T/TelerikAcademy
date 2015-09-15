using System;

class SquareOf
{
    static void Main()
    {
        int number = 12345;
        // Using Math.Pow();
        Console.WriteLine("Square of {0} is {1} ", number, Math.Pow(number, 2));

        // This is the fastest way, because Math.Pow(); is implemented to work with double variables
        // => significantly slower then just multiplying
        Console.WriteLine("Square of {0} is {1} ", number, number * number);
    }
}