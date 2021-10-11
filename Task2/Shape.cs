using System;

namespace Task2
{
    abstract class Shape
    {
        protected static void PositivenessCheck(double x)
        {
            if (x <= 0)
                throw new ArgumentException("value must be positive");
        }
        public abstract double Area();
        public abstract double Perimeter();
    }
}
