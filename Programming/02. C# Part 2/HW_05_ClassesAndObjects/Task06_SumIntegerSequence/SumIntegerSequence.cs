using System;

/* You are given a sequence of positive integer values
 * written into a string, separated by spaces. Write a
 * function that reads these values from given string
 * and calculates their sum. Example:
 *      string = "43 68 9 23 318"  result = 461
 */

class SumIntegerSequence
{
    static void Main()
    {
        string sequence = "43 68 9 23 318";
        string[] numbers = sequence.Split(' ');
        int sum = 0;
        foreach (string a in numbers)
        {
            sum += int.Parse(a);
        }
        Console.WriteLine(sum);
    }
}
