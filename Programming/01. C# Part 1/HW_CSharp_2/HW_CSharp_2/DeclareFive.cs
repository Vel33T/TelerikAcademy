/* Declare five variables choosing for each of them the
 * most appropriate of the types byte, sbyte, short, ushort,
 * int, uint, long, ulong to represent the following
 * values: 52130, -115, 4825932, 97, -10000.
 */

using System;

class DeclareFive
{
    static void Main()
    {
        byte one = 97;
        sbyte two = -115;
        short three = -10000;
        ushort four = 52130;
        int five = 4825932;

        Console.WriteLine("Most appropriate types as follows:");
        Console.WriteLine("{0} -> byte",one);
        Console.WriteLine("{0} -> sbyte", two);
        Console.WriteLine("{0} -> short", three);
        Console.WriteLine("{0} -> ushort", four);
        Console.WriteLine("{0} -> int", five);
    }
}




