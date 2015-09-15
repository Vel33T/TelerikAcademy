using System;

class BitThree
{
    static void Main()
    {
        Console.Write("Find if the bit 3 is 1 or 0. \r\nEnter Number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        bool isOne = ((number >> 3) & 1) == 1;

        Console.WriteLine(isOne ? "Bit 3 is 1" : "Bit 3 is 0");
    }
}

