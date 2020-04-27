using System;

namespace DotNetDemoSolution.Reflection
{

    [RemarkAttribute("Attribute is used in this class.", Supplement = "This is additional info.")]
    class MyClass
    {
        int x;
        int y;

        public MyClass(int a)
        {
            x = y = a;
        }
        public MyClass(int a, int b)
        {
            x = a;
            y = b;
        }
        public int Sum()
        {
            return x + y;
        }
        public bool IsBetween(int i)
        {
            return x < i && i < y;
        }
        public void Set(int a, int b)
        {
            x = a;
            y = b;
        }
        public void Set(double a, double b)
        {
            x = (int)a;
            y = (int)b;
        }
        public void Show()
        {
            Console.WriteLine("x: {0}, y: {1}", x, y);
        }
    }
}
