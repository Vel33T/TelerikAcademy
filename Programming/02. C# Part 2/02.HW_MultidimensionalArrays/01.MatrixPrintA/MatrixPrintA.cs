using System;

/* Write a program that fills and prints a matrix of size
 * (n, n) as shown below: (examples for n = 4)
 */

    class MatrixPrintA
    {
        static void PrintMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,4}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int count = 1;

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row,col] = count++;
                }
            }
            PrintMatrix(matrix);
        }
    }
