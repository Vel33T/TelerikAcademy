/* Declare two string variables and assign them with
 * “Hello” and “World”. Declare an object variable and
 * assign it with the concatenation of the first two
 * variables (mind adding an interval). Declare a third 
 * string variable and initialize it with the value of 
 * the object variable (you should perform type casting).
 */

using System;

class TypeCasting
{
    static void Main()
    {
        string one = "Hello";
        string two = "World!";

        object concatanate = one + " " + two;

        string three = (string)concatanate + " I am Vel.";

        Console.WriteLine(one);
        Console.WriteLine(two);
        Console.WriteLine(concatanate);
        Console.WriteLine(three);
    }
}
