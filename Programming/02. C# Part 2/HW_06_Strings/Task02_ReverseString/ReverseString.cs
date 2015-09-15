using System;

/* Write a program that reads a string, reverses it
 * and prints the result at the console.
 * Example: "sample"  "elpmas".
 */

class ReverseString
{
    static void Main()
    {
        string normal = Console.ReadLine();
        char[] strArr = normal.ToCharArray();
        Array.Reverse(strArr);

        Console.WriteLine(strArr);
    }
}
