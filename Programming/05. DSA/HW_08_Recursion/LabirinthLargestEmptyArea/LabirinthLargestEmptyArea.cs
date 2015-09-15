using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirinthLargestEmptyArea
{
    class LabirinthLargestEmptyArea
    {
        static char[,] lab = new char[,]{
                                            {' ', ' ', ' ', '*', ' ', ' ', ' '},
                                            {'*', '*', ' ', '*', ' ', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                            {' ', '*', '*', '*', '*', '*', ' '},
                                            {' ', ' ', ' ', ' ', ' ', ' ', ' '},
                                        };

        static bool[,] visited = new bool[lab.GetLength(0), lab.GetLength(1)];

        static int cellCount = 0;

        static void Main()
        {
            //Starting position
            int startX = 0;
            int startY = 0;

            FindAllPaths(startY, startX);

            Console.WriteLine("Largest area is {0} cells.", cellCount);
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

            visited[row, col] = true;
            cellCount++;

            FindAllPaths(row, col + 1);
            FindAllPaths(row + 1, col);
            FindAllPaths(row, col - 1);
            FindAllPaths(row - 1, col);
        }
    }
}
