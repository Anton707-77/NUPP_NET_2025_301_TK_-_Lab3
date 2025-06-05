using System;

namespace GeometricShapes
{
    public class Square : Shape
    {
        public double SideLength { get; set; }

        public Square() : base()
        {
        }

        public Square(double sideLength) : base()
        {
            SideLength = sideLength;
        }

        public Square(double x, double y, double sideLength) : base(x, y)
        {
            SideLength = sideLength;
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }

        public override double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public override void Resize(double factor)
        {
            SideLength *= factor;
        }

        public override void Rotate(double angle)
        {
            // Реалізація обертання квадрата (необов'язково для демонстрації)
        }
    }
}
