using System;

namespace GeometricShapes
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle() : base()
        {
        }

        public Circle(double radius) : base()
        {
            Radius = radius;
        }

        public Circle(double x, double y, double radius) : base(x, y)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override void Resize(double factor)
        {
            Radius *= factor;
        }

        public override void Rotate(double angle)
        {
            // Коло не змінюється при обертанні
        }
    }
}
