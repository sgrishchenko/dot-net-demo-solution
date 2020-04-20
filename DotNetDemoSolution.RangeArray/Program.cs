using System;

namespace DotNetDemoSolution.RangeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            RangeArray range1 = new RangeArray(-5, 5);
            RangeArray range2 = new RangeArray(1, 10);
            RangeArray range3 = new RangeArray(-20, -12);

            Console.WriteLine("range1 length: " + range1.Length);
            for (int i = -5; i <= 5; i++)
                range1[i] = i;

            Console.Write("range1 content: ");
            for (int i = -5; i <= 5; i++)
                Console.Write(range1[i] + " ");

            Console.WriteLine();

            Console.WriteLine("range2 length: " + range2.Length);
            for (int i = 1; i <= 10; i++)
                range2[i] = i;

            Console.Write("range2 content: ");
            for (int i = 1; i <= 10; i++)
                Console.Write(range2[i] + " ");

            Console.WriteLine();

            Console.WriteLine("range3 length: " + range3.Length);
            for (int i = -20; i <= -12; i++)
                range3[i] = i;

            Console.Write("range3 content: ");
            for (int i = -20; i <= -12; i++)
                Console.Write(range3[i] + " ");

            Console.WriteLine();

            try
            {
                RangeArray range4 = new RangeArray(100, -10);
            }
            catch (RangeArrayException exception)
            {
                Console.WriteLine(exception);
            }

            try
            {
                RangeArray range4 = new RangeArray(-2, 2);
                for (int i = -2; i <= 2; i++)
                    range4[i] = i;
                
                Console.Write("range4 : ");
                for (int i = -2; i <= 10; i++)
                    Console.Write(range4[i] + " ");
            }
            catch (RangeArrayException exception)
            {
                Console.WriteLine(exception);
            }
        }
    }
}
