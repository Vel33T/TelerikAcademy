using System;

 /* A company has name, address, phone number, fax
  * number, web site and manager. The manager has
  * first name, last name, age and a phone number.
  * Write a program that reads the information about a
  * company and its manager and prints them on the
  * console. */

class PrintCompanyAndManagerInfo
{
    static void Main()
    {
        Console.Write("Enter company's name: ");
        string companyName = Console.ReadLine();

        Console.Write("Enter company;s address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Enter phone number: ");
        string companyPhoneNumber = Console.ReadLine();

        Console.Write("Enter fax number: ");
        string companyFaxNumber = Console.ReadLine();

        Console.Write("Enter web site: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Enter manager's first name: ");
        string managerFirstName = Console.ReadLine();

        Console.Write("Enter last name: ");
        string managerLastName = Console.ReadLine();

        Console.Write("Enter age: ");
        byte managerAge = byte.Parse(Console.ReadLine());

        Console.Write("Enter phone number: ");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine(companyName);
        Console.WriteLine(companyAddress);
        Console.WriteLine(companyPhoneNumber);
        Console.WriteLine(companyFaxNumber);
        Console.WriteLine(companyWebSite);
        Console.WriteLine(managerFirstName);
        Console.WriteLine(managerLastName);
        Console.WriteLine(managerAge);
        Console.WriteLine(managerPhoneNumber);
    }
}

