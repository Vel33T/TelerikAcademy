/* Declare  two integer variables and assign them with
 * 5 and 10 and after that exchange their values.
 */

using System;

class ValuesExchange
{
    static void Main()
    {
        //Console.WriteLine("Enter the numbers you want to swap.");

        //int a = int.Parse(Console.ReadLine());
        //int b = int.Parse(Console.ReadLine());
        int a = 5;
        int b = 10;

        //First way to do it. Only for integer values!!!
        a = a + b;
        b = a - b;
        a = a - b;

        ////The following two ways will work with any type of data.
        ////Second way.
        //int x = 0;
        //x = a;
        //a = b;
        //b = x;

        ////Third way.
        //a ^= b;
        //b ^= a;
        //a ^= b;


        Console.WriteLine();
        Console.WriteLine(a);
        Console.WriteLine(b);
    }
}

