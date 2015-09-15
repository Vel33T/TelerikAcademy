namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtils.GetFileExtension("example"));
            Console.WriteLine(FileUtils.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", GeometryUtils.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", GeometryUtils.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", GeometryUtils.CalcVolume(10, 3, 5));
            Console.WriteLine("Diagonal XYZ = {0:f2}", GeometryUtils.CalcDiagonal3D(2, 3, 4));
            Console.WriteLine("Diagonal XY = {0:f2}", GeometryUtils.CalcDiagona2D(2, 3));
            Console.WriteLine("Diagonal XZ = {0:f2}", GeometryUtils.CalcDiagona2D(2, 4));
            Console.WriteLine("Diagonal YZ = {0:f2}", GeometryUtils.CalcDiagona2D(3, 4));
        }
    }
}
