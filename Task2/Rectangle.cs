namespace Task2
{
    class Rectangle : Shape
    {
        public readonly double A, B;
        public Rectangle(double a, double b)
        {
            PositivenessCheck(a);
            PositivenessCheck(b);
            A = a;
            B = b;
        }
        public override double Area() => A * B;
        public override double Perimeter() => 2 * (A + B);
    }
}
