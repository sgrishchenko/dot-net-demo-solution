using System;

namespace DotNetDemoSolution.ThreeD
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreeD a = new ThreeD(1, 2, 3);
            ThreeD b = new ThreeD(10, 10, 10);
            ThreeD c;

            Console.WriteLine("Coordinates of point a: " + a);
            Console.WriteLine("Coordinates of point b: " + b);

            c = a + b;
            Console.WriteLine("Result of addition a + b: " + c);

            c = a + b + c;
            Console.WriteLine("Result of addition a + b + c: " + c);

            c = c - a;
            Console.WriteLine("Result of subtraction c - a: " + c);

            c = c - b;
            Console.WriteLine("Result of subtraction c - b: " + c);

            c = -a;
            Console.WriteLine("Result of assignment -a: " + c);

            Console.WriteLine();

            c = a++;
            Console.WriteLine("If c = a++");
            Console.WriteLine("than coordinates of point c: " + c);
            Console.WriteLine("and coordinates of point a: " + a);

            a = new ThreeD(1, 2, 3);
            Console.WriteLine();
            Console.WriteLine("Setting of initial coordinates of point a: " + a);
            Console.WriteLine();

            c = --a;
            Console.WriteLine("If c = --a");
            Console.WriteLine("than coordinates of point c: " + c);
            Console.WriteLine("and coordinates of point a: " + a);

            Console.WriteLine();

            c = b + 10;
            Console.WriteLine("Result of addition b + 10: " + c);
            c = 15 + b;
            Console.WriteLine("Result of addition 15 + b: " + c);
            c = b - 5;
            Console.WriteLine("Result of subtraction b - 5: " + c);

            ThreeD i = new ThreeD(5, 6, 7);
            ThreeD j = new ThreeD(10, 10, 10);
            ThreeD k = new ThreeD(1, 2, 3);
            ThreeD l = new ThreeD(6, 7, 5);

            Console.WriteLine();

            if (i > k) Console.WriteLine("i > k is true");
            if (i < k) Console.WriteLine("i < k is true");
            if (i > j) Console.WriteLine("i > j is true");
            if (i < j) Console.WriteLine("i < j is true");

            if (i > l)
            {
                Console.WriteLine("i > l is true");
            }
            else if (i < l)
            {
                Console.WriteLine("i < l is true");
            }
            else
            {
                Console.WriteLine("Points i and l are at the same distance from the origin");
            }

            c = new ThreeD(0, 0, 0);

            Console.WriteLine();

            if (a) Console.WriteLine("Point a is true.");
            else Console.WriteLine("Point a is false.");
            if (b) Console.WriteLine("Point b is true.");
            else Console.WriteLine("Point b is false.");
            if (c) Console.WriteLine("Point c is true.");
            else Console.WriteLine("Point c is false.");

            Console.WriteLine();

            if (a) Console.WriteLine("Point a is true.");
            if (b) Console.WriteLine("Point b is true.");
            if (c) Console.WriteLine("Point c is true.");

            if (!a) Console.WriteLine("Point a is false.");
            if (!b) Console.WriteLine("Point b is false.");
            if (!c) Console.WriteLine("Point c is false.");

            Console.WriteLine();

            if (a & b) Console.WriteLine("a & b is true.");
            else Console.WriteLine("a & b is false.");
            if (a & c) Console.WriteLine("a & c is true.");
            else Console.WriteLine("a & c is false.");
            if (a | b) Console.WriteLine("a | b is true.");
            else Console.WriteLine("a | b is false.");
            if (a | c) Console.WriteLine("a | c is true.");
            else Console.WriteLine("a | c is false.");

            Console.WriteLine();

            if (a && b) Console.WriteLine("a && b is true.");
            else Console.WriteLine("a && b is false.");
            if (a && c) Console.WriteLine("a && c is true.");
            else Console.WriteLine("a && c is false.");
            if (a || b) Console.WriteLine("a || b is true.");
            else Console.WriteLine("a || b is false.");
            if (a || c) Console.WriteLine("a || c is true.");
            else Console.WriteLine("a || c is false.");

            Console.WriteLine();

            Console.WriteLine("Controlling a loop with an object of class ThreeD.");
            do
            {
                Console.WriteLine(b);
                b--;
            } while (b);
        }
    }
}
