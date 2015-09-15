/* Write a program that safely compares floating-point
 * numbers with precision of 0.000001. Examples:
 * (5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true
 */

using System;

class SafeCompare
{
    static void Main()
    {
        //Console.Write("Enter the first number: ");
        //float numberOne = float.Parse(Console.ReadLine());

        //Console.Write("Enter the second number: ");
        //float numberTwo = float.Parse(Console.ReadLine());

        float numberOne = 5.3f;
        float numberTwo = 6.01f;

        float precision = 0.000001f;
        bool compare = (Math.Abs(numberOne - numberTwo) < precision);

        Console.WriteLine(compare);
    }
}
