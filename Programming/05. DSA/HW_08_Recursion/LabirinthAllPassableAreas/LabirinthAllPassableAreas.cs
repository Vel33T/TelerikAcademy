namespace LabirinthAllPassableAreas
{
    using System;

    class LabirinthAllPassableAreas
    {
        static char[,] lab = new char[,]{
                                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                                            {'*', '*', '*', '*', ' ', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', '*', '*', '*', '*', '*', '*'},
                                            {' ', ' ', ' ', ' ', '*', ' ', ' '},
                                        };
        static bool[,] visited = new bool[lab.GetLength(0), lab.GetLength(1)];
        static int cellCount = 0;

        static void Main()
        {
            for (int row = 0; row < lab.GetLength(0); row++)
            {
                for (int col = 0; col < lab.GetLength(1); col++)
                {
                    //Optimization for not calling the method if we are on non-empty cell
                    if (visited[row, col] == false)
                    {
                        FindAllPaths(row, col);

                        // Printing and reseting cellCount if there are empty cells found
                        if (cellCount > 1)
                        {
                            Console.WriteLine("Area of {0} found", cellCount);
                            cellCount = 0;
                        }
                    }
                }
            }
        }

        private static void FindAllPaths(int row, int col)
        {
            if ((row < 0) || (col < 0) || (row >= lab.GetLength(0)) || (col >= lab.GetLength(1)))
            {
                return;
            }

            if (lab[row, col] != ' ' || visited[row, col])
            {
                return;
            }

            visited[row, col] = true;
            cellCount++;

            FindAllPaths(row, col + 1);
            FindAllPaths(row + 1, col);
            FindAllPaths(row, col - 1);
            FindAllPaths(row - 1, col);
        }
    }
}
