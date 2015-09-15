using System;
using System.Collections.Generic;

namespace Point
{
    public class Path
    {
        public List<Point3D> Paths = new List<Point3D>();

        public void AddPoint(Point3D point)
        {
            Paths.Add(point);
        }

        public void PrintPath()
        {
            foreach (var point in Paths)
            {
                Console.WriteLine(point);
            }
        }
    }
}
