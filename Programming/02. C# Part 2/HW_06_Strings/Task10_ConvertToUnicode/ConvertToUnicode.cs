using System;

/* Write a program that converts a string to
 * a sequence of C# Unicode character literals.
 * Use format strings.
 */

class ConvertToUnicode
{
    //Version 1 when I didn't know how to combine {0:0000} with {0:X}
    //static void Main()
    //{
    //    string input = Console.ReadLine();
    //    string temp = "";
    //    for (int i = 0; i < input.Length; i++)
    //    {
    //        temp = String.Format("{0:x}",((int)input[i]));
    //        Console.Write("\\u{0}", temp.PadLeft(4, '0'));
    //    }
    //    Console.WriteLine();
    //}

    //Version 2 after rereading a section of the C# Book :)
    static void Main()
    {
        string input = Console.ReadLine();
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("//u{0:X4}", (int)input[i]);
        }
        Console.WriteLine();
    }
}
