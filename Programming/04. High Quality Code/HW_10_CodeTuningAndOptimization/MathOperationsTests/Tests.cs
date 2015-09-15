using System;
using System.Diagnostics;
using System.Linq;

namespace MathOperationsTests
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

        static void Main()
        {
            #region Add Tests
            Console.WriteLine("Add tests!");
            Console.Write("For int:\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 50000000; i += 3)
                {
                }
            });

            Console.Write("For long:\t");
            DisplayExecutionTime(() =>
            {
                for (long i = 0; i < 50000000; i += 3)
                {
                }
            });

            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                for (float i = 0f; i < 50000000f; i += 3f)
                {
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                for (double i = 0d; i < 50000000d; i += 3d)
                {
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                for (decimal i = 0m; i < 50000000m; i += 3m)
                {
                }
            });
            #endregion

            #region Substract Tests
            Console.WriteLine("------------------------");
            Console.WriteLine("Substract tests!");
            Console.Write("For int:\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 50000000; i >= 0; i -= 3)
                {
                }
            });

            Console.Write("For long:\t");
            DisplayExecutionTime(() =>
            {
                for (long i = 50000000l; i >= 0l; i -= 3l)
                {
                }
            });

            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                for (float i = 50000000f; i >= 0f; i -= 3f)
                {
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                for (double i = 50000000d; i >= 0d; i -= 3d)
                {
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                for (decimal i = 50000000m; i >= 0m; i -= 3m)
                {
                }
            });
            #endregion

            #region Increment Tests
            Console.WriteLine("------------------------");
            Console.WriteLine("Increment tests!");
            Console.Write("For int:\t");
            DisplayExecutionTime(() =>
            {
                for (int i = 0; i < 5000000; i++)
                {
                }
            });

            Console.Write("For long:\t");
            DisplayExecutionTime(() =>
            {
                for (long i = 0l; i < 5000000l; i++)
                {
                }
            });

            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                for (float i = 0f; i < 5000000f; i++)
                {
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                for (double i = 0d; i < 5000000d; i++)
                {
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                for (decimal i = 0m; i < 5000000m; i++)
                {
                }
            });
            #endregion

            #region Multiply and Devide Tests
            Console.WriteLine("------------------------");
            Console.WriteLine("Multiply and divide tests!");
            Console.Write("For int:\t");
            DisplayExecutionTime(() =>
            {
                int result = 2345;
                for (int i = 1; i < 400000; i++)
                {
                    result *= 23478;
                    result /= 23477;
                }
            });

            Console.Write("For long:\t");
            DisplayExecutionTime(() =>
            {
                long result = 2345l;
                for (int i = 1; i < 400000; i++)
                {
                    result *= 23478l;
                    result /= 23477l;
                }
            });

            Console.Write("For float:\t");
            DisplayExecutionTime(() =>
            {
                float result = 2345f;
                for (int i = 1; i < 400000; i++)
                {
                    result *= 23478f;
                    result /= 23477f;
                }
            });

            Console.Write("For double:\t");
            DisplayExecutionTime(() =>
            {
                double result = 2345d;
                for (int i = 1; i < 400000; i++)
                {
                    result *= 23478d;
                    result /= 23477d;
                }
            });

            Console.Write("For decimal:\t");
            DisplayExecutionTime(() =>
            {
                decimal result = 2345m;
                for (int i = 1; i < 400000; i++)
                {
                    result *= 23478m;
                    result /= 23477m;
                }
            });
            #endregion
        }
    }
}
