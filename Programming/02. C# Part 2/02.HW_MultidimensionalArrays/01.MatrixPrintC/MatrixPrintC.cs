using System;

class MatrixPrintC
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

        for (int row = n - 1; row >= 0; row--)
        {
            for (int col = 0; col < n - row; col++)
            {
                matrix[row + col, col] = count++;
            }
        }

        for (int col = 1; col < n; col++)
        {
            for (int row = 0; row < n - col; row++)
            {
                matrix[row, col + row] = count++;
            }
        }
        PrintMatrix(matrix);
    }
}
