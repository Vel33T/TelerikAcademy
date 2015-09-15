using System;

/* Write a program that reads a rectangular matrix of
 * size N x M and finds in it the square 3 x 3 that has
 * maximal sum of its elements.
 */

class SquareMaxSum
{
    //    static int n = int.Parse(Console.ReadLine());
    //    static int m = int.Parse(Console.ReadLine());

    //    Did it like that to be easier for testing.
    static int[,] matrix =  
    {
        { 1, 2, 5, 8, -5 },
        { 3, 2, 43, 5, 2 },
        { 2, 1, 3, 4, -2 },
        { 2, -1, 9, 4, 6 },
        { 1, 1, 1, 1, 99 }
    };

    static int Summing(int row, int col)
    {
        int sum = 0;
        for (int i = row; i < 3 + row; i++)
        {
            for (int j = col; j < 3 + col; j++)
            {
                sum += matrix[i, j];
            }
        }
        return sum;
    }

    static void PrintMatrix(int row, int col)
    {
        for (int i = row; i < 3 + row; i++)
        {
            for (int j = col; j < 3 + col; j++)
            {
                Console.Write("{0,4} ", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void Main()
    {

        int rowMax = 0;
        int colMax = 0;
        int maxSum = 0;

        for (int i = 0; i <= matrix.GetLength(0) - 3; i++)
        {
            for (int j = 0; j <= matrix.GetLength(1) - 3; j++)
            {
                int temp = Summing(i, j);
                if (temp > maxSum)
                {
                    maxSum = temp;
                    rowMax = i;
                    colMax = j;
                }
            }
        }
        PrintMatrix(rowMax, colMax);
    }
}
