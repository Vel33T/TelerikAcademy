using System;

/* Write a program that reads an integer number and
 * calculates and prints its square root. If the number is
 * invalid or negative, print "Invalid number". In all
 * cases finally print "Good bye". Use try-catch-finally.
 */

    class SqrtExceptions
    {
        static void Main()
        {
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                Console.WriteLine(Math.Sqrt(number));
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.Error.WriteLine("The number must be positive!");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine("Entered number is not valid!");
            }
            catch (ArgumentNullException)
            {
                Console.Error.WriteLine("Entered number is not valid!");
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Entered number format is not valid!");
            }
            finally
            {
                Console.WriteLine("Good Bye! :)");
            }
        }
    }
