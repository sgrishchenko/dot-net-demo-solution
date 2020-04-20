namespace DotNetDemoSolution.Shapes
{
    class Rectangle : TwoDShape
    {

        public Rectangle(double width, double height) : base("rectangle", width, height)
        { }

        public bool IsSquare()
        {
            if (Width == Height) return true;
            return false;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }
}