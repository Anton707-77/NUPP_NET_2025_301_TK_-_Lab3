using System;

namespace GeometricShapes
{
    public abstract class Shape
    {
        public double X { get; set; }
        public double Y { get; set; }
        public static int ShapeCount { get; private set; }

        public Shape()
        {
            ShapeCount++;
        }

        public Shape(double x, double y) : this()
        {
            X = x;
            Y = y;
        }

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public void Move(double deltaX, double deltaY)
        {
            X += deltaX;
            Y += deltaY;
        }

        public abstract void Resize(double factor);

        public abstract void Rotate(double angle);
    }
}
