namespace LabirinthAllPaths
{
    using System;

    // The task is almost the same as the sample given in the presentation
    class LabirinthAllPaths
    {
        static char[,] lab = new char[,]{
                                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                                            {'*', '*', ' ', '*', ' ', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', '*', '*', '*', '*', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                        };

        static bool[,] visited = new bool[lab.GetLength(0), lab.GetLength(1)];

        static int pathCount = 0;

        static void Main()
        {
            //Starting position
            int startX = 0;
            int startY = 0;

            //End
            int endX = 6;
            int endY = 4;
            lab[endY, endX] = 'e';

            FindAllPaths(startY, startX);

            Console.WriteLine("{0} paths found.", pathCount);
        }

        private static void FindAllPaths(int row, int col)
        {
            if ((row < 0) || (col < 0) || (row >= lab.GetLength(0)) || (col >= lab.GetLength(1)))
            {
                return;
            }
            if (lab[row, col] == '*' || visited[row, col])
            {
                return;
            }
            if (lab[row, col] == 'e')
            {
                pathCount++;
                return;
            }

            visited[row, col] = true;

            FindAllPaths(row, col + 1);
            FindAllPaths(row + 1, col);
            FindAllPaths(row, col - 1);
            FindAllPaths(row - 1, col);

            visited[row, col] = false;
        }
    }
}
