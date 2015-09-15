using System;

class BitAtPossitionP
{
    static void Main()
    {
        Console.Write("Enter number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        Console.Write("Enter position: ");
        string str2 = Console.ReadLine();
        int position = int.Parse(str2);

        Console.WriteLine(((number >> position) & 1) == 1);
    }
}

