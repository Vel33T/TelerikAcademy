using System;
using System.Linq;
using System.Collections.Generic;

namespace Minesweeper
{
    public class Game
    {
        static void Main()
        {
            string command = string.Empty;
            char[,] board = CreateBoard();
            char[,] bombs = CreateBombs();
            int counter = 0;
            bool hasExpoded = false;
            List<Score> champions = new List<Score>(6);
            int row = 0;
            int col = 0;
            bool isGameStarting = true;
            const int MaxScore = 35;
            bool isGameCompleted = false;

            do
            {
                if (isGameStarting)
                {
                    Console.WriteLine("Lets play “Minesweeper”. Try your luck and find the places without bombs.");
                    Console.WriteLine("Commands:");
                    Console.WriteLine(" 'top' -> top players \n 'restart' -> new game \n 'exit' -> closes the program");
                    PrintBoard(board);
                    isGameStarting = false;
                }
                Console.Write("Enter row and column: ");

                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out col) &&
                        row <= board.GetLength(0) && col <= board.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        DisplayScores(champions);
                        break;
                    case "restart":
                        board = CreateBoard();
                        bombs = CreateBombs();
                        PrintBoard(board);
                        hasExpoded = false;
                        isGameStarting = false;
                        break;
                    case "exit":
                        Console.WriteLine("Good Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                PlayTurn(board, bombs, row, col);
                                counter++;
                            }
                            if (MaxScore == counter)
                            {
                                isGameCompleted = true;
                            }
                            else
                            {
                                PrintBoard(board);
                            }
                        }
                        else
                        {
                            hasExpoded = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nError! Invalid command.\n");
                        break;
                }
                if (hasExpoded)
                {
                    PrintBoard(bombs);
                    Console.Write("\nOops! You died! Your score is {0} points. " +
                        "Enter your nickname: ", counter);
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(score);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < score.Points)
                            {
                                champions.Insert(i, score);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }
                    champions.Sort((Score r1, Score r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Score r1, Score r2) => r2.Points.CompareTo(r1.Points));
                    DisplayScores(champions);

                    board = CreateBoard();
                    bombs = CreateBombs();
                    counter = 0;
                    hasExpoded = false;
                    isGameStarting = true;
                }
                if (isGameCompleted)
                {
                    Console.WriteLine("\nCongratulations!!! You cleared the field without hitting a bomb!");
                    PrintBoard(bombs);
                    Console.WriteLine("Enter your nickname, master: ");
                    string nickname = Console.ReadLine();
                    Score score = new Score(nickname, counter);
                    champions.Add(score);
                    DisplayScores(champions);

                    board = CreateBoard();
                    bombs = CreateBombs();
                    counter = 0;
                    isGameCompleted = false;
                    isGameStarting = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria!");
            Console.Read();
        }

        private static void DisplayScores(List<Score> scores)
        {
            Console.WriteLine("\nScores:");
            if (scores.Count > 0)
            {
                for (int i = 0; i < scores.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", 
                        i + 1, scores[i].Name, scores[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty!\n");
            }
        }

        private static void PlayTurn(char[,] board,
            char[,] bombs, int row, int col)
        {
            char bombsAroundNumber = GetBombsAroundNumberAtPosition(bombs, row, col);
            bombs[row, col] = bombsAroundNumber;
            board[row, col] = bombsAroundNumber;
        }

        private static void PrintBoard(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int row = 0; row < rows; row++)
            {
                Console.Write("{0} | ", row);
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(string.Format("{0} ", board[row, col]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateBoard()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int row = 0; row < boardRows; row++)
            {
                for (int col = 0; col < boardColumns; col++)
                {
                    board[row, col] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] board = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    board[row, col] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(rows * cols);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int row = (number / cols);
                int col = (number % cols);
                board[row, col] = '*';
            }

            return board;
        }

        //The following method is not used at all

        //private static void SetBombsAround(char[,] board)
        //{
        //    int rows = board.GetLength(0);
        //    int cols = board.GetLength(1);

        //    for (int row = 0; row < rows; row++)
        //    {
        //        for (int col = 0; col < cols; col++)
        //        {
        //            if (board[row, col] != '*')
        //            {
        //                char bombsAroundNumber = GetBombsAroundNumber(board, row, col);
        //                board[row, col] = bombsAroundNumber;
        //            }
        //        }
        //    }
        //}

        private static char GetBombsAroundNumberAtPosition(char[,] board, int row, int col)
        {
            int bombsNumber = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    bombsNumber++;
                }
            }
            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    bombsNumber++;
                }
            }
            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    bombsNumber++;
                }
            }
            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    bombsNumber++;
                }
            }
            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    bombsNumber++;
                }
            }
            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    bombsNumber++;
                }
            }
            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    bombsNumber++;
                }
            }
            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    bombsNumber++;
                }
            }
            return char.Parse(bombsNumber.ToString());
        }
    }
}
