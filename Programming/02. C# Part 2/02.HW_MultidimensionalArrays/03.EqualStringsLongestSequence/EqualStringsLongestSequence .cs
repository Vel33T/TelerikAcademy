using System;

/* We are given a matrix of strings of size N x M.
 * Sequences in the matrix we define as sets of several
 * neighbor elements located on the same line, column
 * or diagonal. Write a program that finds the longest
 * sequence of equal strings in the matrix.
 */

class EqualStringsLongestSequence
{
    static string[,] matrix = 
        {
            { "ha", "fi", "ho", "sd" },
            { "fo", "ha", "ho", "sd" },
            { "xx", "ho", "ha", "hi" },
            { "ho", "si", "ho", "ha" }
        };
    static int maxSeq = 0;
    static int direction = 0;
    static int counter = 1;
    static string element = "";

    static void SearchLeftToRight()
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxSeq)
                {
                    maxSeq = counter;
                    element = matrix[row, col];
                    direction = 1;
                }
            }
            counter = 1;
        }
    }

    static void SearchTopToBottom()
    {
        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    counter++;
                }
                else
                {
                    counter = 1;
                }
                if (counter > maxSeq)
                {
                    maxSeq = counter;
                    element = matrix[row, col];
                    direction = 2;
                }
            }
            counter = 1;
        }
    }

    static void SearchDiagonalLeftToRight()
    {
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < matrix.GetLength(1) - 1; j++)
            {
                for (int row = i, col = j; (row < matrix.GetLength(0) - 1) && (col < matrix.GetLength(1) - 1); row++, col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        element = matrix[row, col];
                        direction = 3;
                    }
                }
                counter = 1;
            }
        }
    }

    static void SearchDiagonalRightToLeft()
    {
        for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        {
            for (int j = 1; j < matrix.GetLength(1); j++)
            {
                for (int row = i, col = j; (row < matrix.GetLength(0) - 1) && (col > 0); row++, col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        counter++;
                    }
                    else
                    {
                        counter = 1;
                    }
                    if (counter > maxSeq)
                    {
                        maxSeq = counter;
                        element = matrix[row, col];
                        direction = 4;
                    }
                }
                counter = 1;
            }
        }
    }

    static void PrintResults()
    {
        switch (direction)
        {
            case 0: Console.WriteLine("There is no repetition of elements");
                break;
            case 1: Console.WriteLine("{0} repeats {1} times from left to right", element, maxSeq);
                break;
            case 2: Console.WriteLine("{0} repeats {1} times from top to bottom", element, maxSeq);
                break;
            case 3: Console.WriteLine("{0} repeats {1} times from left to right diagonally", element, maxSeq);
                break;
            case 4: Console.WriteLine("{0} repeats {1} times from right to left diagonally", element, maxSeq);
                break;
        }
    }

    static void Main()
    {
        SearchLeftToRight();
        SearchTopToBottom();
        SearchDiagonalLeftToRight();
        SearchDiagonalRightToLeft();
        PrintResults();
    }
}
