using System;


class MatrixPrintD
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

        for (int index = 0; index <= n / 2; index++)
        {
            for (int row = index; row < n - index - 1; row++)
            {
                matrix[row, index] = count++;
            }
            for (int col = index; col < n - index - 1; col++)
            {
                matrix[n - index - 1, col] = count++;
            }
            for (int row = n - index - 1; row > index; row--)
            {
                matrix[row, n - index - 1] = count++;
            }
            for (int col = n - index - 1; col > index; col--)
            {
                matrix[index, col] = count++;
            }
            if ((n & 1) == 1)
            {
                matrix[n / 2, n / 2] = count;
            }
        }
        PrintMatrix(matrix);
    }
}
