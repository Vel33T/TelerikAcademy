using System;

/* Write a program that shows the sign (+ or -) of the
 * product of three real numbers without calculating it.
 * Use a sequence of if statements.
 */ 


class SignOfTheProduct
{
    static void Main()
    {
        Console.Write("Enter first real number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second real number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter third real number: ");
        int c = int.Parse(Console.ReadLine());

        if ((a > 0) && (b > 0) && (c > 0))                          // + + +
            Console.WriteLine("The product's sign is '+'");         
        else if ((a > 0) && (b > 0) && (c < 0))                     // + + -
            Console.WriteLine("The product's sign is '-'");
        else if ((a > 0) && (b < 0) && (c > 0))                     // + - +
            Console.WriteLine("The product's sign is '-'");
        else if ((a > 0) && (b < 0) && (c < 0))                     // + - -
            Console.WriteLine("The product's sign is '+'");
        else if ((a < 0) && (b > 0) && (c > 0))                     // - + +
            Console.WriteLine("The product's sign is '-'");
        else if ((a < 0) && (b > 0) && (c < 0))                     // - + -
            Console.WriteLine("The product's sign is '+'");
        else if ((a < 0) && (b < 0) && (c > 0))                     // - - +
            Console.WriteLine("The product's sign is '+'");
        else                                                        // - - -
            Console.WriteLine("The product's sign is '-'");
    }
}

