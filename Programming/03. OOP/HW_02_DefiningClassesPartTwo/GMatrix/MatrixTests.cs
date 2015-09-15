using System;

namespace GMatrix
{
    class MatrixTests
    {
        static void Main()
        {
            int[,] first = new int[,]
            {
                {1, 2, -3},
                {2, 1, 3},
                {3, 1, 2}
            };

            int[,] second = new int[,]
            {
                {4, 5, 6},
                {-1, 0, 7},
                {3, 2, 1}
            };

            Matrix<int> firstMatrix = new Matrix<int>(first);
            Matrix<int> secondMatrix = new Matrix<int>(second);

            Console.WriteLine(firstMatrix + secondMatrix);
            Console.WriteLine(firstMatrix - secondMatrix);
            Console.WriteLine(firstMatrix * secondMatrix);

            if (firstMatrix)
            {
                Console.WriteLine("firstMatrix have no zeros!");
            }
            Console.WriteLine();

            //Here I tried to fill one Matrix with chars
            Matrix<char> chars = new Matrix<char>(10, 10);
            int count = 0;
            for (int i = 0; i < chars.Rows; i++)
            {
                for (int j = 0; j < chars.Cols; j++)
                {
                    chars[i, j] = (char)(count + 'A');
                }
                count++;
            }
            Console.WriteLine(chars);
        }
    }
}
