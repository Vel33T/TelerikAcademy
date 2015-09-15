using System;

namespace BoolToStringClass
{
    public class Printer
    {
        public const int MaxCount = 6;

        internal class BoolPrinter
        {
            public void PrintBool(bool value)
            {
                string boolAsString = value.ToString();
                Console.WriteLine(boolAsString);
            }
        }

        public static void Main()
        {
            Printer.BoolPrinter printer = new Printer.BoolPrinter();
            printer.PrintBool(true);
        }
    }
}
