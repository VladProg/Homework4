using System;

namespace Task1
{
    class RegularTriangle : Triangle
    {
        private RegularTriangle(double a) : base(a, a, a) { }
        public static RegularTriangle FromSide(double a) => new(a);
        public static RegularTriangle FromArea(double area) => new(Math.Sqrt(area / Math.Sqrt(3) * 2));
        public override double A
        {
            get => base.A;
            set => base.A = base.B = base.C = value;
        }
        public override double B
        {
            get => base.B;
            set => base.A = base.B = base.C = value;
        }
        public override double C
        {
            get => base.C;
            set => base.A = base.B = base.C = value;
        }
        public double Area
        {
            get => A * A * Math.Sqrt(3) / 4;
            set => A = Math.Sqrt(PositivenessCheck(value) / Math.Sqrt(3) * 4);
        }
    }
}
