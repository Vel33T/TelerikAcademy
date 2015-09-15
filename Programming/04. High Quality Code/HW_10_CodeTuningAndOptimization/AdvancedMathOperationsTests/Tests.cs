using System;
using System.Diagnostics;
using System.Linq;

namespace AdvancedMathOperationsTests
{
    class Tests
    {
        static void DisplayExecutionTime(Action action)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            action();
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Square root tests!");
            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                float number = 23.54f;
                for (float i = 0; i < 500000; i++)
                {
                    Math.Sqrt(number);
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                double number = 23.54d;
                for (double i = 0; i < 500000; i++)
                {
                    Math.Sqrt(number);
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 23.54m;
                for (decimal i = 0; i < 500000; i++)
                {
                    Math.Sqrt((double)number);
                }
            });

            Console.WriteLine("------------------");
            Console.WriteLine("Natural logarithm tests!");
            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                float number = 23.54f;
                for (float i = 0; i < 500000; i++)
                {
                    Math.Log10(number);
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                double number = 23.54d;
                for (double i = 0; i < 500000; i++)
                {
                    Math.Log10(number);
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 23.54m;
                for (decimal i = 0; i < 500000; i++)
                {
                    Math.Log10((double)number);
                }
            });

            Console.WriteLine("------------------");
            Console.WriteLine("Sinus tests!");
            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                float number = 23.54f;
                for (float i = 0; i < 500000; i++)
                {
                    Math.Sin(number);
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                double number = 23.54d;
                for (double i = 0; i < 500000; i++)
                {
                    Math.Sin(number);
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal number = 23.54m;
                for (decimal i = 0; i < 500000; i++)
                {
                    Math.Sin((double)number);
                }
            });
        }
    }
}
