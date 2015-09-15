using System;
using System.IO;

namespace Point
{
    public static class PathStorage
    {
        public static void SavePath(Path path)
        {
            using (StreamWriter writer = new StreamWriter("..//..//SavedPaths.txt"))
            {
                foreach (var point in path.Paths)
                {
                    writer.WriteLine(point);
                }
            }
        }

        public static Path LoadPath()
        {
            Path result = new Path();
            using (StreamReader reader = new StreamReader("..//..//LoadPaths.txt"))
            {
                char[] separators = { ',', '(', ')', ' ' };
                string line = reader.ReadLine();
                while (line != null)
                {
                    Point3D point = new Point3D();
                    string[] points = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                    point.XCoord = int.Parse(points[0]);
                    point.YCoord = int.Parse(points[1]);
                    point.ZCoord = int.Parse(points[2]);
                    result.AddPoint(point);
                    line = reader.ReadLine();
                }
            }
            return result;
        }
    }
}
