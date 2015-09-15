/* Create a program that assigns null values to an 
 * integer and to double variables. Try to print them on 
 * the console, try to add some values or the null
 * literal to them and see the result.
 */

using System;

class PlayingWithNull
{
    static void Main()
    {
        int? intNull = null;
        double? doubleNull = null;

        Console.WriteLine(intNull);
        Console.WriteLine(doubleNull);
        Console.WriteLine(intNull + 5);
        Console.WriteLine(doubleNull + 5.5);
        Console.WriteLine(5 + null);
    }
}
 