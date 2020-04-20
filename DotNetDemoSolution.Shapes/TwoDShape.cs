using System;

namespace DotNetDemoSolution.Shapes
{
    abstract class TwoDShape
    {
        double width;
        double height;

        public string Name;

        public TwoDShape(string name, double width, double height)
        {
            Name = name;
            Width = width;
            Height = height;
        }

        public TwoDShape(TwoDShape template)
        {
            Width = template.Width;
            Height = template.Height;
            Name = template.Name;
        }

        public double Width
        {
            get { return width; }
            set { width = Math.Abs(value); }
        }
        public double Height
        {
            get { return height; }
            set { height = Math.Abs(value); }
        }

        public void ShowDimencions()
        {
            Console.WriteLine("Width: " + Width);
            Console.WriteLine("Height: " + Height);
        }

        public abstract double Area();
    }
}