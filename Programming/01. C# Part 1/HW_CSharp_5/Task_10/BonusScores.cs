using System;

/* Write a program that applies bonus scores to given
 * scores in the range [1..9]. The program reads a digit
 * as an input. If the digit is between 1 and 3, the
 * program multiplies it by 10; if it is between 4 and 6,
 * multiplies it by 100; if it is between 7 and 9,
 * multiplies it by 1000. If it is zero or if the value is not
 * a digit, the program must report an error.
 * Use a switch statement and at the end print the
 * calculated new value in the console.
 */

class BonusScores
{
    static void Main()
    {
        Console.Write("Enter a digit: ");
        string input = Console.ReadLine();
        byte digit = 0;
        bool isDigit = byte.TryParse(input, out digit);
        int result = 0;

        if (isDigit)
        {
            switch (digit)
            {
                case 1:
                case 2:
                case 3:
                    result = digit * 10;
                    Console.WriteLine("The result is: {0}", result);
                    break;
                case 4:
                case 5:
                case 6:
                    result = digit * 100;
                    Console.WriteLine("The result is: {0}", result);
                    break;
                case 7:
                case 8:
                case 9:
                    result = digit * 1000;
                    Console.WriteLine("The result is: {0}", result);
                    break;
                case 0:
                    Console.WriteLine("Error! Zero is not valid input!"); break;
                default:
                    Console.WriteLine("Error!"); break;
            }
        }
        else
        {
            Console.WriteLine("Error! The input is not a digit.");
        }
    }
}