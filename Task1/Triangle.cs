using System;

namespace Task1
{
    class Triangle
    {
        protected static double PositivenessCheck(double x)
        {
            if (x <= 0)
                throw new ArgumentException("value must be positive");
            return x;
        }
        private double _a;
        public virtual double A
        {
            get => _a;
            set => _a = PositivenessCheck(value);
        }
        private double _b;
        public virtual double B
        {
            get => _b;
            set => _b = PositivenessCheck(value);
        }
        private double _c;
        public virtual double C
        {
            get => _c;
            set => _c = PositivenessCheck(value);
        }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool Correct() => A < B + C && B < A + C && C < A + B;
        private void _correctnessCheck()
        {
            if (!Correct())
                throw new InvalidOperationException("triangle inequality doesn't hold");
        }
        private static double _radToDeg(double deg) => deg / Math.PI * 180;
        public double Alpha()
        {
            _correctnessCheck();
            return _radToDeg(Math.Acos((B * B + C * C - A * A) / (2 * B * C)));
        }
        public double Beta()
        {
            _correctnessCheck();
            return _radToDeg(Math.Acos((A * A + C * C - B * B) / (2 * A * C)));
        }
        public double Gamma()
        {
            _correctnessCheck();
            return _radToDeg(Math.Acos((A * A + B * B - C * C) / (2 * A * B)));
        }
        public double Perimeter()
        {
            _correctnessCheck();
            return A + B + C;
        }
    }
}
