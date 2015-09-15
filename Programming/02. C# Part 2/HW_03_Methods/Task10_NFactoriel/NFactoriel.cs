using System;

class NFactoriel
{
    static void Print(byte[] factoriel)
    {
        for (int i = factoriel.Length - 1; i >= 0; i--)
        {
            Console.Write(factoriel[i]);
        }
        Console.WriteLine();
    }

    static byte[] Add(byte[] first, byte[] second)
    {
        if (first.Length > second.Length)
        {
            return Add(second, first);
        }

        byte[] temp = new byte[(second.Length) + 1];

        byte remainder = 0;
        int i = 0;

        for (; i < first.Length; i++)
        {
            temp[i] = (byte)((first[i] + second[i] + remainder) % 10);
            remainder = (byte)((first[i] + second[i] + remainder) / 10);
        }

        for (; i < second.Length; i++)
        {
            temp[i] = (byte)((second[i] + remainder) % 10);
            remainder = (byte)((second[i] + remainder) / 10);
        }

        if (remainder != 0)
        {
            temp[i] = 1;
        }
        else
        {
            Array.Resize(ref temp, temp.Length - 1);
        }
        return temp;
    }

    static byte[] Multiplication(byte[] x, int factorialOf)
    {
        byte[] temp = { 0 };
        for (int i = 0; i < factorialOf; i++)
        {
            temp = Add(temp, x);
        }
        return temp;
    }

    static void Main()
    {
        byte[] factorial = { 1 };
        for (int i = 1; i <= 100; i++)
        {
            factorial = Multiplication(factorial, i);
            Print(factorial);
        }
    }
}
