using System;

namespace GeometricShapes
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() : base()
        {
        }

        public Rectangle(double width, double height) : base()
        {
            Width = width;
            Height = height;
        }

        public Rectangle(double x, double y, double width, double height) : base(x, y)
        {
            Width = width;
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height);
        }

        public override void Resize(double factor)
        {
            Width *= factor;
            Height *= factor;
        }

        public override void Rotate(double angle)
        {
            // Реалізація обертання прямокутника (необов'язково для демонстрації)
        }
    }
}
