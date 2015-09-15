namespace LabirinthOnePath
{
    using System;

    // The task is almost the same as the sample given in the presentation
    class LabirinthOnePath
    {
        static char[,] lab = new char[100, 100];

        static bool[,] visited = new bool[lab.GetLength(0), lab.GetLength(1)];

        static bool pathFound = false;

        static void Main()
        {
            //Starting position
            int startX = 0;
            int startY = 0;

            //End
            int endX = 99;
            int endY = 99;
            lab[endY, endX] = 'e';

            FindAllPaths(startY, startX);

            if (pathFound)
            {
                Console.WriteLine("A path is found!");
            }
            else
            {
                Console.WriteLine("No path found!");
            }
        }

        private static void FindAllPaths(int row, int col)
        {
            if (pathFound)
            {
                return;
            }

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
                pathFound = true;
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
