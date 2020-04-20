using System;

namespace DotNetDemoSolution.Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle("isosceles", width: 4.0, height: 4.0);
            Triangle t2 = new Triangle("rectangular", width: 8.0, height: 12.0);

            Console.WriteLine("t1 info: ");
            t1.ShowStyle();
            t1.ShowDimencions();
            Console.WriteLine("Area: " + t1.Area());

            Console.WriteLine();

            Console.WriteLine("t2 info: ");
            t2.ShowStyle();
            t2.ShowDimencions();
            Console.WriteLine("Area: " + t2.Area());

            Console.WriteLine();

            Rectangle r1 = new Rectangle(width: 5.0, height: 10.0);
            Rectangle r2 = new Rectangle(width: 6.0, height: 6.0);

            Console.WriteLine("r1 info: ");
            Console.WriteLine("Is square: " + r1.IsSquare());
            r1.ShowDimencions();
            Console.WriteLine("Area: " + r1.Area());

            Console.WriteLine();

            Console.WriteLine("r2 info: ");
            Console.WriteLine("Is square: " + r1.IsSquare());
            r2.ShowDimencions();
            Console.WriteLine("Area: " + r2.Area());

            Console.WriteLine();

            TwoDShape[] shapes = new TwoDShape[] { t1, t2, r1, r2 };
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Shape: " + shapes[i].Name);
                Console.WriteLine("Area: " + shapes[i].Area());
                Console.WriteLine();
            }
        }
    }
}
