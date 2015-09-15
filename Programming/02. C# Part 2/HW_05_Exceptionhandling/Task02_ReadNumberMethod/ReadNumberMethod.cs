using System;

/* Write a method ReadNumber(int start, int end)
 * that enters an integer number in given range
 * [start…end]. If an invalid number or non-number text
 * is entered, the method should throw an exception.
 * Using this method write a program that enters 10 numbers:
 *      a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 */

class ReadNumberMethod
{
    static int ReadNumber(int start, int end)
    {
        int number = int.Parse(Console.ReadLine());
        if (!(number > start && number < end))
        {
            throw new ArgumentOutOfRangeException();
        }
        return number;
    }

    static void Main()
    {
        
        try
        {
            int n = 0;
            for (int i = 1; i <= 10; i++)
            {
                n = ReadNumber(n, 100);
            }
        }
        catch (OverflowException)
        {
            Console.Error.WriteLine("Number out of scope!");
        }
        catch (ArgumentNullException)
        {
            Console.Error.WriteLine("Invalid number!");
        }
        catch (FormatException)
        {
            Console.Error.WriteLine("Not an integer number!");
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.Error.WriteLine("The number is not in range!");
        }
    }


}
