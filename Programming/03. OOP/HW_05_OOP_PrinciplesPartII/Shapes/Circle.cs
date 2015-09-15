using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Shapes
{
    public class Circle : Shape
    {
        public Circle(double radius)
        {
            this.Width = radius;
        }

        public override double CalculateSurface()
        {
            return Math.PI * this.Width * this.Width;
        }
    }
}
