using System;

/* Write a program to check if in a given
 * expression the brackets are put correctly.
 * Example of correct expression: ((a+b)/5-d).
 * Example of incorrect expression: )(a+b)).
 */

class CorrectBrackets
{

    static bool Check(string expression)
    {
        int count = 0;
        foreach (char letter in expression)
        {
            if (count < 0)
            {
                return false;
            }
            else if (letter == '(')
            {
                count++;
            }
            else if (letter == ')')
            {
                count--;
            }
        }
        if (count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    static void Main()
    {
        string expression = Console.ReadLine();
        Console.WriteLine(Check(expression) ? "The brackets are put correctly" : "The brackets are not put correctly");
    }
  
}
