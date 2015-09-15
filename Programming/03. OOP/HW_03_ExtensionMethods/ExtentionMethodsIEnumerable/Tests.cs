using System;

namespace ExtentionMethodsIEnumerable
{
    class Tests
    {
        static void Main(string[] args)
        {
            double[] test = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            Console.WriteLine("Sum: " + test.Sum<double>());
            Console.WriteLine("Product: " + test.Product<double>());
            Console.WriteLine("Average: " + test.Average<double>());
            Console.WriteLine("Min: " + test.Min<double>());
            Console.WriteLine("Max: " + test.Max<double>());
        }
    }
}
