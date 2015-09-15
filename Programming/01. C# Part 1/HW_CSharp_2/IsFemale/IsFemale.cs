/* Declare a boolean variable called isFemale and
 * assign an appropriate value corresponding to your gender.
 */

using System;

class IsFemale
{
    static void Main()
    {
        Console.Write("You are a female? (true/false): ");
        bool isFemale = bool.Parse(Console.ReadLine());

        if (isFemale)
        {
            Console.WriteLine("Yes I am a female!");
        }
        else
        {
            Console.WriteLine("No I'm not a female!");
        }
    }
}

