namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        //Private fields
        private double width;
        private double height;

        //Constructor
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        //Properties
        public double Width
        {
            get { return this.width; }
            set
            {
                if (this.width <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input data! Width must be greater then zero!");
                }
                else
                {
                    this.width = value;
                }
            }
        }

        public double Height
        {
            get { return this.height; }
            set
            {
                if (this.height <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input data! Height must be greater then zero!");
                }
                else
                {
                    this.height = value;
                }
            }
        }

        //Overriden public Methods
        public override double CalcPerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}
