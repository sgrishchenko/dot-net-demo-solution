using System;

namespace DotNetDemoSolution.Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stk1 = new Stack(10);
            Stack stk2 = new Stack(10);
            Stack stk3 = new Stack(10);
            char ch;
            int i;

            Console.WriteLine("Put А-J symbols в stack stk1.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));
            if (stk1.IsFull()) Console.WriteLine("Stack stk1 is full.");

            Console.Write("Content of stack stk1: ");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                Console.Write(ch);
            }
            Console.WriteLine();
            if (stk1.IsEmpty()) Console.WriteLine("Stack stk1 is empty.\n");

            Console.WriteLine("Put А-J symbols в stack stk1 again.");
            for (i = 0; !stk1.IsFull(); i++)
                stk1.Push((char)('A' + i));

            Console.WriteLine("Now get symbols from stack stk1");
            Console.WriteLine("and put them in stack stk2.");
            while (!stk1.IsEmpty())
            {
                ch = stk1.Pop();
                stk2.Push(ch);
            }

            Console.Write("Content of stack stk2: ");
            while (!stk2.IsEmpty())
            {
                ch = stk2.Pop();
                Console.Write(ch);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Put 5 symbols in stack stk3.");
            for (i = 0; i < 5; i++)
                stk3.Push((char)('A' + i));
            Console.WriteLine("Stack stk3 capacity: " + stk3.Capacity());
            Console.WriteLine("Object count in stack stk3: " + stk3.GetNum());
        }
    }
}
