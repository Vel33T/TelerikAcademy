using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Tests
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>
            {
                new Triangle(5, 4.5),
                new Rectangle(5.5, 4.5),
                new Circle(5),
            };

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape.CalculateSurface());
            }
        }
    }
}
