using System;

namespace Task3
{
    class IsoscelesTriangle : Triangle
    {
        public IsoscelesTriangle(double a, double gamma) // бічна сторона і кут при вершині
            : base(a, a, gamma) { }
        private static double _degToRad(double deg) => deg / 180 * Math.PI;
        public override double Area() => A * A * Math.Sin(_degToRad(Gamma)) / 2;
        public override double Perimeter() => 2 * A + 2 * A * Math.Sin(_degToRad(Gamma / 2));
    }
}
