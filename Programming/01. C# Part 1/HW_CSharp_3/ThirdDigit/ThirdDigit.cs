using System;

class ThirdDigit
{
    static void Main()
    {
        Console.Write("If the third digit is 7 (right-to-left).\r\nEnter number: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        bool result = (number / 100) % 10 == 7;

        Console.WriteLine(result);
    }
}

