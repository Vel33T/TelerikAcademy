namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        //Private field
        private double radius;

        //Constructor
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        //Property
        public double Radius
        {
            get { return this.radius; }
            set 
            {
                if (this.radius <= 0)
                {
                    throw new ArgumentOutOfRangeException("Invalid input data! Radius must be greater then zero!");
                }
                else
                {
                    this.radius = value; 
                }
            }
        }

        //Overriden public Methods
        public override double CalcPerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalcSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }
    }
}
