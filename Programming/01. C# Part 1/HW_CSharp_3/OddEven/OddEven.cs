using System;

class OddEven
{
    static void Main()
    {
        Console.Write("Checking if integer is odd or even. Enter number: ");
        string str = Console.ReadLine();
        int a = int.Parse(str);

        ////we can use bitwise operations too
        //if ((a & 1) == 0)
        if (a % 2 == 0)
            Console.WriteLine("The number {0} is even.", a);
        else
            Console.WriteLine("The number {0} is odd.", a);
    }
}
