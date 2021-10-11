using System;

namespace Task2
{
    class Disk : Shape
    {
        readonly double R;
        public Disk(double r)
        {
            PositivenessCheck(r);
            R = r;
        }
        public override double Area() => Math.PI * R * R;
        public override double Perimeter() => 2 * Math.PI * R;
    }
}