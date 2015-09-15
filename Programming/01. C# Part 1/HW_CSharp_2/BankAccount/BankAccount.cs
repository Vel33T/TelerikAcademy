/* A bank account has a holder name (first name,
 * middle name and last name), available amount of
 * money (balance), bank name, IBAN, BIC code and 3
 * credit card numbers associated with the account.
 * Declare the variables needed to keep the information
 * for a single bank account using the appropriate
 * data types and descriptive names.
 */

using System;

class BankAccount
{
    static void Main()
    {
        //Console.Write("First name: ");
        //string firstName = Console.ReadLine();

        //Console.Write("Middle name: ");
        //string middleName = Console.ReadLine();

        //Console.Write("Last name: ");
        //string lastName = Console.ReadLine();

        //string holderName = firstName + " " + middleName + " " + lastName;

        //Console.Write("Enter the available ammount of money: ");
        //double balance = double.Parse(Console.ReadLine());

        //Console.Write("Enter bank name: ");
        //string bankName = Console.ReadLine();

        //Console.Write("Enter IBAN: ");
        //string iBan = Console.ReadLine();

        //Console.Write("Enter BIC code: ");
        //string bicCode = Console.ReadLine();

        //Console.Write("Enter credit card N1: ");
        //ulong cardNumber1 = ulong.Parse(Console.ReadLine());

        //Console.Write("Enter credit card N2: ");
        //ulong cardNumber2 = ulong.Parse(Console.ReadLine());

        //Console.Write("Enter credit card N3: ");
        //ulong cardNumber3 = ulong.Parse(Console.ReadLine());

        string firstName = "Gosho";
        string middleName = "Peshov";
        string lastName = "Barabeshov";
        string holderName = firstName + " " + middleName + " " + lastName;
        decimal balance = 5000.46m;
        string bankName = "ProCredit Bank";
        string iBan = "BG33PRCB92354876315423";
        string bicCode = "PRCBBGSF";
        ulong cardNumberOne = 0;
        ulong cardNumberTwo = 0;
        ulong cardNumberThree = 0;


        Console.WriteLine("Entered info.\nHolder name: {0}\nBalance: {1}\nBank name: {2}\nIBAN: {3}\nBIC code: {4}\nCredit card N1: {5}\nCredit card N3: {6}\nCredit card N3: {7}\n",
            holderName, balance, bankName, iBan, bicCode, cardNumberOne, cardNumberTwo, cardNumberThree);
    }
}

