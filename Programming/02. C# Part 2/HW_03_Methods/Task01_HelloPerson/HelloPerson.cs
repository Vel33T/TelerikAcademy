using System;

/* Write a method that asks the user for his name and
 * prints “Hello, <name>” (for example, “Hello,
 * Peter!”). Write a program to test this method.
 */

class HelloPerson
{
    static void HelloPersonPrint(string name)
    {
        Console.WriteLine("Hello, {0}!", name);
    }

    static void Main()
    {
        string name = Console.ReadLine();
        HelloPersonPrint(name);
    }
}

