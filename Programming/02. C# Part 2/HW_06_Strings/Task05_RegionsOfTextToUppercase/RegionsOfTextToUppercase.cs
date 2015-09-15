﻿using System;
using System.Text.RegularExpressions;

/* You are given a text. Write a program that changes
 * the text in all regions surrounded by the tags 
 * upcase> and </upcase> to uppercase.
 * The tags cannot be nested. 
 */

class RegionsOfTextToUppercase
{
    static void Main()
    {
        string text = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string result = Regex.Replace(text, "<upcase>(.*?)</upcase>", temp => temp.Groups[1].Value.ToUpper());
        Console.WriteLine(result);
    }
}
