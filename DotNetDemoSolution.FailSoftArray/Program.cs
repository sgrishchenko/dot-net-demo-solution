using System;

namespace DotNetDemoSolution.FailSoftArray
{
    class Program
    {
        static void Main(string[] args)
        {
            FailSoftArray failSoft = new FailSoftArray(5);

            Console.WriteLine("Hidden fail.");
            for (int i = 0; i < (failSoft.Length * 2); i++)
            {
                failSoft[i] = i * 10;
            }

            for (int i = 0; i < (failSoft.Length * 2); i++)
            {
                int x = failSoft[i];
                if (x != -1) Console.Write(x + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Fail with error message.");
            for (int i = 0; i < (failSoft.Length * 2); i++)
            {
                failSoft[i] = i * 10;
                if (failSoft.Error)
                    Console.WriteLine("failSoft[" + i + "] out of bounds");
            }
            for (int i = 0; i < (failSoft.Length * 2); i++)
            {
                int x = failSoft[i];
                if (!failSoft.Error) Console.Write(x + " ");
                else
                    Console.WriteLine("failSoft[" + i + "] out of bounds");
            }

            Console.WriteLine();

            Console.WriteLine("failSoft[1] : " + failSoft[1]);
            Console.WriteLine("failSoft[2] : " + failSoft[2]);
            Console.WriteLine("failSoft[1.1]: " + failSoft[1.1]);
            Console.WriteLine("failSoft[1.6]: " + failSoft[1.6]);
        }
    }
}
