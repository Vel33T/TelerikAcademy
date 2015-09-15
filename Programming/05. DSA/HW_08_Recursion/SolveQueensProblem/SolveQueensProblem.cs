namespace SolveQueensProblem
{
    using System;

    class Program
    {
        static int count = 0;

        static void Main()
        {
            int size = 8;

            SolveQueens(new bool[size, size], new int[size, size], 0);

            Console.WriteLine(count);
        }

        static void SolveQueens(bool[,] board, int[,] occupied, int columnIndex)
        {
            if (columnIndex == board.GetLength(0))
            {
                count++;
                return;
            }

            for (int rowIndex = 0; rowIndex < board.GetLength(0); rowIndex++)
            {
                if (occupied[rowIndex, columnIndex] == 0)
                {
                    board[rowIndex, columnIndex] = true;
                    MarkOccupied(occupied, +1, rowIndex, columnIndex);
                    SolveQueens(board, occupied, columnIndex + 1);
                    board[rowIndex, columnIndex] = false;
                    MarkOccupied(occupied, -1, rowIndex, columnIndex);
                }
            }
        }

        private static void MarkOccupied(int[,] occupied, int value, int row, int column)
        {
            for (int i = 0; i < occupied.GetLength(0); i++)
            {
                occupied[i, column] += value;
                occupied[row, i] += value;

                if (column + i < occupied.GetLength(0) && row + i < occupied.GetLength(0))
                {
                    occupied[row + i, column + i] += value;
                }

                if (column + i < occupied.GetLength(0) && row - i >= 0)
                {
                    occupied[row - i, column + i] += value;
                }
            }
        }
    }
}
