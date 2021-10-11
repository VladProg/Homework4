using System;

namespace Task3
{
    abstract class Triangle
    {
        public readonly double A, B, Gamma;
        public Triangle(double a, double b, double gamma)
        {
            if (a <= 0 || b <= 0)
                throw new ArgumentException("side must be positive");
            if (gamma <= 0 || gamma >= 180)
                throw new ArgumentException("angle must be in interval (0°, 180°)");
            A = a;
            B = b;
            Gamma = gamma;
        }
        public abstract double Area();
        public abstract double Perimeter();
    }
}
