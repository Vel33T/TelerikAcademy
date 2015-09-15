using System;

/* Write a program that, depending on the user's
 * choice inputs int, double or string variable. If the
 * variable is integer or double, increases it with 1. If
 * the variable is string, appends "*" at its end. The
 * program must show the value of that variable as a
 * console output. Use switch statement.
 */


class UsersChoice
{
    static void Main()
    {
        Console.Write("Input '1' for int, '2' for double, '3' for string: ");
        byte choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter integer: ");
                int first = int.Parse(Console.ReadLine());
                Console.WriteLine(first + 1);
                break;

            case 2:
                Console.Write("Enter real number: ");
                double second = double.Parse(Console.ReadLine());
                Console.WriteLine(second + 1.0);
                break;

            case 3:
                Console.Write("Enter string: ");
                string third = Console.ReadLine();
                Console.WriteLine(third + "*");
                break;

            default:
                Console.WriteLine("Invalid input!");
                break;
        }
    }
}

