using System;
using System.Collections.Generic;

/* A dictionary is stored as a sequence of text lines
 * containing words and their explanations. Write a
 * program that enters a word and translates it by
 * using the dictionary. 
 */

class Dictionary
{
    static void Main()
    {
        var dict = new Dictionary<string, string>()
        {
            { ".NET", "platform for applications from Microsoft" },
            { "CLR", "managed execution environment for .NET" },
            { "namespace", "hierarchical organization of classes" }
        };

        string search = Console.ReadLine();

        Console.WriteLine("{0}", dict[search]);
    }
}
