using System;

namespace Point
{
     public struct Point3D
    {
        public int XCoord { get; set; }
        public int YCoord { get; set; }
        public int ZCoord { get; set; }

        public static readonly Point3D ZeroCoord = new Point3D(0,0,0);

        public Point3D(int xCoord, int yCoord, int zCoord)
        {
            this.XCoord = xCoord;
            this.YCoord = yCoord;
            this.ZCoord = zCoord;
        }

        public override string ToString()
        {
 	        return String.Format("3D Point with coordinates: (x={0}, y={1}, z={2})", XCoord, YCoord, ZCoord);
        }
    }
}
