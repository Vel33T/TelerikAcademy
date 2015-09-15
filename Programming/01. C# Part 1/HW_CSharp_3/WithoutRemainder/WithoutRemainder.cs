using System;


class WithoutRemainder
{
    static void Main()
    {
        Console.WriteLine("Checking for a given integer if it can be devided by 7 and 5 (without remainder) in the same time.");
        Console.Write("Enter number: ");
        string str = Console.ReadLine();
        int a = int.Parse(str);
        //bool isDividable = (a % 5 == 0) && (a % 7 == 0);
        bool isDividable = a % 35 == 0;

        Console.WriteLine(isDividable ? "It can be divided without reminder" : " It cannot be divided without reminder");
    }
}

