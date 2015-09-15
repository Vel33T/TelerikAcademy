using System;

    class GivenBitOfGivenInteger
    {
        static void Main()
        {
            Console.Write("Enter integer: ");
            string str = Console.ReadLine();
            int number = int.Parse(str);

            Console.Write("Enter bit: ");
            string str2 = Console.ReadLine();
            int bit = int.Parse(str2);

            if (((number >> bit) & 1) == 1)
                Console.WriteLine("The value of bit {0} is 1", bit);
            else
                Console.WriteLine("The value of bit {0} is 0", bit);
        }
    }
