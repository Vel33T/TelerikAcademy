/* Which of the following values can be assigned to a 
 * variable of type float and which to a variable of type
 * double: 34.567839023, 12.345, 8923.1234857, 3456.091?
 */

using System;

class DoubleOrFloat
{
    static void Main()
    {
        double one = 34.567839023D;
        float two = 12.345F;
        double three = 8923.1234857D;
        float four = 3456.091F;

        Console.WriteLine("To float can be assigned {0} and {1}", two, four);
        Console.WriteLine("To double can be assigned {0} and {1}", one, three);
    }
}


