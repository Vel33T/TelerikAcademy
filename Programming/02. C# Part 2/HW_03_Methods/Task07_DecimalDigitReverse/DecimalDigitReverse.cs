using System;

/* Write a method that reverses the digits of given
 * decimal number. Example: 256  652
 */

class DecimalDigitReverse
{
    //If we make reverse of the whole number.
    //Not sure if this was the idea, but the 
    //interpretations can be several so... :)
    static decimal Reverse(decimal a)
    {
        string str = a.ToString();
        char[] arrTemp = str.ToCharArray();
        //Little optimization
        if (arrTemp.Length == 1)
        {
            return a;
        }
        Array.Reverse(arrTemp);
        string reversedStr = new string(arrTemp);
        return decimal.Parse(reversedStr);
    }

    static void Main()
    {
        decimal number = decimal.Parse(Console.ReadLine());
        decimal reversed = Reverse(number);
        Console.WriteLine(reversed);
    }
}
