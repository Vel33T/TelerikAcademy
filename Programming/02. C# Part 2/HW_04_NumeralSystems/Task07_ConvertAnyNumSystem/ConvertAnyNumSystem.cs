using System;

/* Write a program to convert from any numeral system of given
 * base s to any other numeral system of base d (2 ≤ s, d ≤  16).
 */

/* I tested the program and it must work
 * for any numerical system. It was not planned :D
 * I mean, since I use the ASCII table it will work
 * with numeral systems with base up to 36, if you
 * use all capital letters ;Pp 
 */                                            
class ConvertAnyNumSystem                       
{                                               
    static void Main()                          
    {                 
        Console.Write("Number to convert: ");   
        string number = Console.ReadLine();
        number = number.ToUpper();

        Console.Write("From numeral system with base: ");
        int s = int.Parse(Console.ReadLine());

        Console.Write("To numeral system with base: ");
        int d = int.Parse(Console.ReadLine());

        /* I hope this one is not very confusing
         * First we go to the method AnyToDec,
         * then with the result of AnyToDec, we directly go to the method DecToAny
         * and from there we directly give the result to the WriteLine to print it on the console */
        Console.WriteLine(DecToAny(AnyToDec(number, s), d));
    }

    static int AnyToDec(string number, int b) //b - base of the numeral system
    {
        int dec = 0;
        int count = 1;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            dec += GetNumber(number[i]) * count;
            count = count * b;
        }
        return dec;
    }

    //With this method I get the decimal representation
    static int GetNumber(char a)
    {
        if (a >= 'A')
        {
            return (int)(a - 'A' + 10);
        }
        else
        {
            return (int)(a - '0');
        }
    }

    static string DecToAny(int dec, int b) // b - base of the numeral system
    {
        string result = "";

        while (dec > 0)
        {
            result = GetString(dec % b) + result;
            dec /= b;
        }
        return result;
    }

    static string GetString(int a)  
    {
        if (a >= 10)
        {
            /* I must test if this is fast enough, if someone
             * have any idea of optimizaion. Please share :)) */
            return ((char)('A' - 10 + a)).ToString();
        }
        else
        {
            return ((char)('0' + a)).ToString();
        }
    }
}
