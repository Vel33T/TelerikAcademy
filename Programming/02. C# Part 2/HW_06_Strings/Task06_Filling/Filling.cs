using System;

/* Write a program that reads from the console a string
 * of maximum 20 characters. If the length of the string
 * is less than 20, the rest of the characters should be
 * filled with '*'. Print the result string into the console.
 */

class Filling
{
    static void Main()
    {
        string someStr = Console.ReadLine();
        someStr = someStr.PadRight(20, '*'); // putting * if there is a need
        someStr = someStr.Substring(0, 20);  // cutting only 20 chars if the string have more
        Console.WriteLine(someStr);
    }
}

// Version 2
// I played a little bit, this was just for the fun :)
// Single line solution :P

//class Filling
//{
//    static void Main()
//    {
//        Console.WriteLine(Console.ReadLine().PadRight(20, '*').Substring(0, 20));
//    }
//}