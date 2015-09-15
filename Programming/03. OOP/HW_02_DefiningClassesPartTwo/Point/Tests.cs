using System;

namespace Point
{
    class Tests
    {
        static void Main()
        {
            Point3D point3D = new Point3D(1, 2, 3);
            Point3D anotherPoint3D = new Point3D(3, 2, 1);
            Console.WriteLine(point3D);
            Console.WriteLine(Point3D.ZeroCoord);

            Console.WriteLine(Distance.Points3D(point3D, Point3D.ZeroCoord));
            Console.WriteLine(Distance.Points3D(point3D, anotherPoint3D));

            Path firstPath = new Path();
            firstPath = PathStorage.LoadPath();
            Console.WriteLine("-----print path-----");
            firstPath.PrintPath();
            Console.WriteLine("-----end-----");

            PathStorage.SavePath(firstPath);
        }
    }
}
