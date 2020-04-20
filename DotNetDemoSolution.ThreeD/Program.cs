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

            Console.WriteLine("Координаты точки a: " + a);
            Console.WriteLine("Координаты точки b: " + b);

            c = a + b;
            Console.WriteLine("Результат сложения а + b: " + c);

            c = a + b + c;
            Console.WriteLine("Результат сложения а + b + с: " + c);

            c = c - a;
            Console.WriteLine("Результат вычитания с - а: " + c);

            c = c - b;
            Console.WriteLine("Результат вычитания с - b: " + c);

            c = -a;
            Console.WriteLine("Результат присваивания -а: " + c);

            Console.WriteLine();

            c = a++;
            Console.WriteLine("Если с = а++");
            Console.WriteLine("то координаты точки с равны " + c);
            Console.WriteLine("а координаты точки а равны " + a);

            a = new ThreeD(1, 2, 3);
            Console.WriteLine();
            Console.WriteLine("Установка исходных координат точки а: " + a);
            Console.WriteLine();

            c = --a;
            Console.WriteLine("Если с = --а");
            Console.WriteLine("то координаты точки с равны " + c);
            Console.WriteLine("а координаты точки а равны " + a);

            Console.WriteLine();

            c = b + 10;
            Console.WriteLine("Результат сложения b + 10: " + c);
            c = 15 + b;
            Console.WriteLine("Результат сложения 15 + b: " + c);
            c = b - 5;
            Console.WriteLine("Результат вычитания b - 5: " + c);

            ThreeD i = new ThreeD(5, 6, 7);
            ThreeD j = new ThreeD(10, 10, 10);
            ThreeD k = new ThreeD(1, 2, 3);
            ThreeD l = new ThreeD(6, 7, 5);

            Console.WriteLine();

            if (i > k) Console.WriteLine("i > k истинно");
            if (i < k) Console.WriteLine("i < k истинно");
            if (i > j) Console.WriteLine("i > j истинно");
            if (i < j) Console.WriteLine("i < j истинно");

            if (i > l)
            {
                Console.WriteLine("i > l истинно");
            }
            else if (i < l)
            {
                Console.WriteLine("i < l истинно");
            }
            else
            {
                Console.WriteLine("Точки i и l находятся на одном расстоянии от начала отсчета");
            }

            c = new ThreeD(0, 0, 0);

            Console.WriteLine();

            if (a) Console.WriteLine("Точка а истинна.");
            else Console.WriteLine("Точка а ложна.");
            if (b) Console.WriteLine("Точка b истинна.");
            else Console.WriteLine("Точка b ложна.");
            if (c) Console.WriteLine("Точка с истинна.");
            else Console.WriteLine("Точка с ложна.");

            Console.WriteLine();

            if (a) Console.WriteLine("Точка а истинна.");
            if (b) Console.WriteLine("Точка b истинна.");
            if (c) Console.WriteLine("Точка с истинна.");

            if (!a) Console.WriteLine("Точка а ложна.");
            if (!b) Console.WriteLine("Точка b ложна.");
            if (!c) Console.WriteLine("Точка с ложна.");

            Console.WriteLine();

            if (a & b) Console.WriteLine("a & b истинно.");
            else Console.WriteLine("a & b ложно.");
            if (a & c) Console.WriteLine("a & с истинно.");
            else Console.WriteLine("a & с ложно.");
            if (a | b) Console.WriteLine("a | b истинно.");
            else Console.WriteLine("a | b ложно.");
            if (a | c) Console.WriteLine("a | с истинно.");
            else Console.WriteLine("a | с ложно.");

            Console.WriteLine();

            if (a && b) Console.WriteLine("a && b истинно.");
            else Console.WriteLine("а && b ложно.");
            if (a && c) Console.WriteLine("а && с истинно.");
            else Console.WriteLine("a && с ложно.");
            if (a || b) Console.WriteLine("a || b истинно.");
            else Console.WriteLine("a || b ложно.");
            if (a || c) Console.WriteLine("a || с истинно.");
            else Console.WriteLine("a || с ложно.");

            Console.WriteLine();

            Console.WriteLine("Управление циклом с помощью объекта класса ThreeD.");
            do
            {
                Console.WriteLine(b);
                b--;
            } while (b);
        }
    }
}
