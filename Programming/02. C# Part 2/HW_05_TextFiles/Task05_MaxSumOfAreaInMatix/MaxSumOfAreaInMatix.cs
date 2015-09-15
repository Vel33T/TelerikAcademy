using System;
using System.IO;

/* Write a program that reads a text file containing a
 * square matrix of numbers and finds in the matrix an
 * area of size 2 x 2 with a maximal sum of its elements.
 * The first line in the input file contains the size of
 * matrix N. Each of the next N lines contain N numbers
 * separated by space. The output should be a single
 * number in a separate text file. 
 */

class MaxSumOfAreaInMatix
{
    static int MaxSum(int[,] matrix)
    {
        int maxSum = 0;
        int tempSum = 0;
        int length = matrix.GetLength(0);
        for (int i = 0; i < length - 1; i++)
        {
            for (int y = 0; y < length - 1; y++)
            {
                tempSum = matrix[i, y] + matrix[i + 1, y] + matrix[i, y + 1] + matrix[i + 1, y + 1];
                if (tempSum > maxSum)
                {
                    maxSum = tempSum;
                }
            }
        }
        return maxSum;
    }

    static int[,] ReadMatrix()
    {
        StreamReader input = new StreamReader("../../TextFile1.txt");

        using (input)
        {
            int size = int.Parse(input.ReadLine());
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++)
            {
                string[] numbers = input.ReadLine().Split(' ');
                for (int j = 0; j < size; j++)
                {
                    matrix[i, j] = int.Parse(numbers[j]);
                }
            }
            return matrix;
        }
    }

    static void Main()
    {
        int result = MaxSum(ReadMatrix());
        Console.WriteLine(result);
    }
}
