namespace Task2
{
    class Square : Shape
    {
        public readonly double A;
        public Square(double a)
        {
            PositivenessCheck(a);
            A = a;
        }
        public override double Area() => A * A;
        public override double Perimeter() => 4 * A;
    }
}
