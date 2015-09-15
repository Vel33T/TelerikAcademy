/* A marketing firm wants to keep record of its
 * employees. Each record would have the following
 * characteristics – first name, family name, age,
 * gender (m or f), ID number, unique employee
 * number (27560000 to 27569999). Declare the
 * variables needed to keep the information for a
 * single employee using appropriate data types
 * and descriptive names.
 */


using System;

class EmployeeRecord
{
    static void Main()
    {
        //Console.Write("Enter your first name: ");
        //string firstName = Console.ReadLine();
        string firstName = "Gosho";

        //Console.Write("Enter your family name: ");
        //string familyName = Console.ReadLine();
        string familyName = "Peshov";

        //Console.Write("Enter your age: ");
        //byte age = byte.Parse(Console.ReadLine());
        byte age = 25;

        //Console.Write("Enter your gender(M/F): ");
        //char gender = char.Parse(Console.ReadLine());
        char gender = 'M';

        //Console.Write("Enter your ID number: ");
        //ulong idNumber = ulong.Parse(Console.ReadLine());
        ulong idNumber = 8707137493;

        //Console.Write("Enter your unique employee number(2756####): ");
        //uint employeeNumber = uint.Parse(Console.ReadLine());
        uint employeeNumber = 27569823;

        //Same types of "if" statements can be added for all the variables,validating the input
        if (employeeNumber > 27569999 || employeeNumber < 27560000)
        {
            //Using exception because this is the right way to handle invalid input in C#
            throw new ArgumentOutOfRangeException("Employee number must be in the range [27560000, 27569999]!");
        }
        Console.WriteLine();
        Console.WriteLine("The entered data looks like:\nFirst name: {0}\nSecond name: {1}\nAge: {2}\nGender: {3}\nID number: {4}\nUnique employee number: {5}", firstName, familyName, age, gender, idNumber, employeeNumber);

    }
}

