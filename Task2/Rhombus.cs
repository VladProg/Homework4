using System;

namespace Task2
{
    class Rhombus : Shape
    {
        public readonly double A, B;
        public Rhombus(double a, double b)
        {
            PositivenessCheck(a);
            PositivenessCheck(b);
            A = a;
            B = b;
        }
        public override double Area() => A * B / 2;
        public override double Perimeter() => 2 * Math.Sqrt(A * A + B * B);
    }
}
