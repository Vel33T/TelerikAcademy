﻿using System;

class BombingCuboids
{
    static int width, height, depth;
    static char[, ,] cuboid;
    static readonly int[] cubesDestroyed = new int[91];
    private const char EmptyCell = ' ';
    static int totalHits = 0;

    private static void ReadCuboid()
    {
        string cuboidSize = Console.ReadLine();
        string[] sizes = cuboidSize.Split();
        width = int.Parse(sizes[0]);
        height = int.Parse(sizes[1]);
        depth = int.Parse(sizes[2]);
        cuboid = new char[width, height, depth];

        for (int h = 0; h < height; h++)
        {
            string line = Console.ReadLine();
            string[] letters = line.Split();
            for (int d = 0; d < depth; d++)
            {
                for (int w = 0; w < width; w++)
                {
                    cuboid[w, h, d] = letters[d][w];
                }
            }
        }
    }

    private static void DetonateBomb(
        int positionWidth, int positionHeight, int positionDepth, int power)
    {
        int startW = Math.Max(0, positionWidth - power);
        int endW = Math.Min(positionWidth + power, width - 1);
        for (int w = startW; w <= endW; w++)
        {
            int startH = Math.Max(0, positionHeight - power);
            int endH = Math.Min(positionHeight + power, height - 1);
            for (int h = startH; h <= endH; h++)
            {
                int startD = Math.Max(0, positionDepth - power);
                int endD = Math.Min(positionDepth + power, depth - 1);
                for (int d = startD; d <= endD; d++)
                {
                    double distance = DistanceSquared(w, h, d, positionWidth, positionHeight, positionDepth);
                    if (distance <= power * power)
                    {
                        char cubeColor = cuboid[w, h, d];
                        if (cubeColor != EmptyCell)
                        {
                            cubesDestroyed[cubeColor]++;
                            totalHits++;
                        }
                        cuboid[w, h, d] = EmptyCell;
                    }
                }
            }
        }
    }

    private static double DistanceSquared(int w1, int h1, int d1, int w2, int h2, int d2)
    {
        return (w1 - w2) * (w1 - w2) + (h1 - h2) * (h1 - h2) + (d1 - d2) * (d1 - d2);
    }

    private static void FallDown(
        int positionWidth, int positionDepth, int power)
    {
        int startW = Math.Max(0, positionWidth - power);
        int endW = Math.Min(positionWidth + power, width - 1);
        for (int w = startW; w <= endW; w++)
        {
            int startD = Math.Max(0, positionDepth - power);
            int endD = Math.Min(positionDepth + power, depth - 1);
            for (int d = startD; d <= endD; d++)
            {
                FallDownPillar(w, d);
            }
        }
    }

    private static void FallDownPillar(int w, int d)
    {
        int startH = 0;
        while ((startH < height) && cuboid[w, startH, d] != EmptyCell)
        {
            startH++;
        }
        if (startH < height - 1)
        {
            int cubeH = startH + 1;
            while ((cubeH < height) && cuboid[w, cubeH, d] == EmptyCell)
            {
                cubeH++;
            }

            while (cubeH < height)
            {
                cuboid[w, startH, d] = cuboid[w, cubeH, d];
                cuboid[w, cubeH, d] = EmptyCell;
                cubeH++;
                startH++;
            }
        }
    }

    static void Main()
    {
        ReadCuboid();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            string[] coordinates = line.Split(' ');
            int w = int.Parse(coordinates[0]);
            int h = int.Parse(coordinates[1]);
            int d = int.Parse(coordinates[2]);
            int power = int.Parse(coordinates[3]);
            DetonateBomb(w, h, d, power);
            FallDown(w, d, power);
        }
        PrintResults();
    }

    private static void PrintResults()
    {
        Console.WriteLine(totalHits);

        for (char color = 'A'; color <= 'Z'; color++)
        {
            int count = cubesDestroyed[color];
            if (count > 0)
            {
                Console.WriteLine("{0} {1}", color, count);
            }
        }
    }
}