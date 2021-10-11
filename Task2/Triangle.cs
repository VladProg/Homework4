using System;

namespace Task2
{
    class Triangle : Shape
    {
        public readonly double A, B, C;
        public Triangle(double a, double b, double c)
        {
            PositivenessCheck(a);
            PositivenessCheck(b);
            PositivenessCheck(c);
            A = a;
            B = b;
            C = c;
            if (A >= B + C || B >= A + C || C >= A + B)
                throw new ArgumentException("triangle inequality doesn't hold");
        }
        public override double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
        public override double Perimeter() => A + B + C;
    }
}
