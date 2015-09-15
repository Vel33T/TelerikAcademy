namespace Labyrinth3D
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Labyrinth3D
    {
        static char[, ,] cube;
        static int cubeLevels;
        static int cubeRows;
        static int cubeCols;

        const char Up = 'U';
        const char Down = 'D';
        const char Stone = '#';
        const char Empty = '.';

        static int shortestPath = int.MaxValue;
        static int stepsCounter = 0;

        static void Main()
        {
            string[] startPos = Console.ReadLine().Split(' ');
            int startX = int.Parse(startPos[0]);
            int startY = int.Parse(startPos[1]);
            int startZ = int.Parse(startPos[2]);

            InitializeCube();

            FindAllPaths(startX, startY, startZ);

            Console.WriteLine(shortestPath);
        }

        private static void FindAllPaths(int level, int row, int col)
        {
            if ((row < 0 || row >= cubeRows) || (col < 0 || col >= cubeCols) )
            {
                return;
            }
            else if (level < 0 || level >= cubeLevels)
            {
                if (stepsCounter < shortestPath)
                {
                    shortestPath = stepsCounter;
                }

                return;
            }
            else if (cube[level, row, col] == Up)
            {
                if (shortestPath < stepsCounter)
                {
                    return;
                }

                cube[level, row, col] = Stone;
                stepsCounter++;

                FindAllPaths(level + 1, row, col);

                cube[level, row, col] = Up;
                stepsCounter--;
            } 
            else if (cube[level, row, col] == Down)
            {
                if (shortestPath < stepsCounter)
                {
                    return;
                }

                cube[level, row, col] = Stone;
                stepsCounter++;

                FindAllPaths(level - 1, row, col);

                cube[level, row, col] = Down;
                stepsCounter--;
            }
            else if (cube[level, row, col] == Stone)
            {
                return;
            }
            else
            {
                if (shortestPath < stepsCounter)
                {
                    return;
                }

                cube[level, row, col] = Stone;
                stepsCounter++;

                FindAllPaths(level, row, col + 1);
                FindAllPaths(level, row, col - 1);
                FindAllPaths(level, row - 1, col);
                FindAllPaths(level, row + 1, col);

                stepsCounter--;
                cube[level, row, col] = Empty;
            }
        }

        private static void InitializeCube()
        {
            string[] cubeSize = Console.ReadLine().Split(' ');
            cubeLevels = int.Parse(cubeSize[0]);
            cubeRows = int.Parse(cubeSize[1]);
            cubeCols = int.Parse(cubeSize[2]);
            cube = new char[cubeLevels, cubeRows, cubeCols];

            for (int level = 0; level < cubeLevels; level++)
            {
                for (int row = 0; row < cubeRows; row++)
                {
                    string inputRow = Console.ReadLine();
                    for (int col = 0; col < cubeCols; col++)
                    {
                        cube[level, row, col] = inputRow[col];
                    }
                }
            }
        }
    }
}
