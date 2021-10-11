using System;

namespace Task3
{
    class RightTriangle : Triangle
    {
        public RightTriangle(double a, double b) // катети
            : base(a, b, 90) { }
        public override double Area() => A * B / 2;
        public override double Perimeter() => A + B + Math.Sqrt(A * A + B * B);
    }
}
