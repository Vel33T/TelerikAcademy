namespace BinaryPasswords
{
    using System;

    class BinaryPasswords
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int starCount = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '*')
                {
                    starCount++;
                }
            }

            long result = 1;
            for (int i = 0; i < starCount; i++)
            {
                result *= 2;
            }

            Console.WriteLine(result);
        }
    }
}
