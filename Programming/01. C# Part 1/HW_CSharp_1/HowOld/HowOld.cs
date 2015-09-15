using System;

class HowOld
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());

        Console.WriteLine("After 10 years I will be {0} years old.", age + 10);
    }
}