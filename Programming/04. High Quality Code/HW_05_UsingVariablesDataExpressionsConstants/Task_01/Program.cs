using System;

class Program
{
    static void Main()
    {
    }

    public class Size
    {
        public Size(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }

    public static Size GetRotatedSize(Size oldSize, double angle)
    {
        double angleCosAbs = Math.Abs(Math.Cos(angle));
        double angleSinAbs = Math.Abs(Math.Sin(angle));
        double width = angleCosAbs * oldSize.Width + angleSinAbs * oldSize.Height;
        double height = angleSinAbs * oldSize.Width + angleCosAbs * oldSize.Height;
        return new Size(width, height);
    }
}

