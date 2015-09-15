using System;

class ModifiesValueAtSinglePosition
{
    static void Main()
    {
        Console.Write("Enter integer: ");
        string str = Console.ReadLine();
        int number = int.Parse(str);

        Console.Write("Enter position: ");
        string str2 = Console.ReadLine();
        int position = int.Parse(str2);

        Console.Write("Enter value(0 or 1): ");
        string str3 = Console.ReadLine();
        int value = int.Parse(str3);

        if (value == 0)
        {
            number = number & (~(1 << position));
        }
        else
        {
            number = number | (1 << position);
        }
        Console.WriteLine("New number: {0}",number);
    }

}