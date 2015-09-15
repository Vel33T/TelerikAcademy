using System;

/* Write methods that calculate the surface of a triangle by given:
 * Side and an altitude to it; Three sides;
 * Two sides and an angle between them. Use System.Math.
 */

class TriangleSurfaceMethods
{
    static void Main()
    {
        Console.WriteLine(SurfaceSideAltitude(5, 4));
        Console.WriteLine(SurfaceThreeSides(3, 4, 5));
        Console.WriteLine(SurfaceTwoSidesAngle(4, 5, 45));
    }

    static double SurfaceSideAltitude(double c, double hc)
    {
        return (c * hc) / 2;
    }

    static double SurfaceThreeSides(double a, double b, double c)
    { 
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    static double SurfaceTwoSidesAngle(double a, double b, double y)
    {
        return (a * b * Math.Sin(Math.PI * y / 180)) / 2;
    }
    
}
