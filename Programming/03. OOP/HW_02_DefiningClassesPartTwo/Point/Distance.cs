using System;

namespace Point
{
    public static class Distance
    {
        public static double Points3D(Point3D first, Point3D second)
        {
            double result = Math.Sqrt(
                (first.XCoord - second.XCoord) * (first.XCoord - second.XCoord) +
                (first.YCoord - second.YCoord) * (first.YCoord - second.YCoord) +
                (first.ZCoord - second.ZCoord) * (first.ZCoord - second.ZCoord));
            return result;
        }
    }
}
