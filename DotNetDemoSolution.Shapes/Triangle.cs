using System;

namespace DotNetDemoSolution.Shapes
{
    class Triangle : TwoDShape
    {
        public string Style;

        public Triangle(string style, double width, double height) : base("triangle", width, height)
        {
            Style = style;
        }

        public override double Area()
        {
            return Width * Height / 2;
        }

        public void ShowStyle()
        {
            Console.WriteLine("Style: " + Style);
        }
    }
}