using System;

namespace DotNetDemoSolution.Delegate
{

    delegate void StringOperation(ref string str);

    delegate int Counter(int end);

    delegate int Increment(int v);

    delegate bool IsEven(int v);

    delegate int IntOperation(int end);

    class Program
    {

        static void ReplaceSpaces(ref string s)
        {
            Console.WriteLine("Spaces replacing.");
            s = s.Replace(' ', '-');
        }

        static void RemoveSpaces(ref string s)
        {
            Console.WriteLine("Spaces removing.");
            s = s.Replace(" ", ""); ;
        }

        static void Reverse(ref string s)
        {
            string temp = "";
            Console.WriteLine("String reversing.");
            for (int i = s.Length - 1; i >= 0; i--)
                temp += s[i];
            s = temp;
        }
        static void Main(string[] args)
        {

            StringOperation strMod;
            string str;

            strMod = ReplaceSpaces;
            str = "This is a simple test.";
            strMod(ref str);
            Console.WriteLine("Result string: " + str);
            Console.WriteLine();

            strMod = RemoveSpaces;
            str = "This is a simple test.";
            strMod(ref str);
            Console.WriteLine("Result string: " + str);
            Console.WriteLine();

            strMod = Reverse;
            str = "This is a simple test.";
            strMod(ref str);
            Console.WriteLine("Result string: " + str);
            Console.WriteLine();

            strMod = ReplaceSpaces;
            strMod += Reverse;
            str = "This is a simple test.";
            strMod(ref str);
            Console.WriteLine("Result string: " + str);
            Console.WriteLine();

            strMod -= ReplaceSpaces;
            strMod += RemoveSpaces;
            str = "This is a simple test.";
            strMod(ref str);
            Console.WriteLine("Result string: " + str);
            Console.WriteLine();

            int result;
            Counter count = delegate (int end)
            {
                int sum = 0;

                for (int i = 0; i <= end; i++)
                {
                    Console.WriteLine(i);
                    sum += i;
                }

                return sum;
            };

            result = count(3);
            Console.WriteLine("Sum 3 is equals " + result);
            Console.WriteLine();
            result = count(5);
            Console.WriteLine("Sum 5 is equals " + result);
            Console.WriteLine();

            Increment increment = count => count + 2;
            Console.WriteLine("Using of lambda expressions increment: ");
            int x = -10;
            while (x <= 0)
            {
                Console.Write(x + " ");
                x = increment(x);
            }
            Console.WriteLine();
            Console.WriteLine();

            IsEven isEven = n => n % 2 == 0;
            Console.WriteLine("Using of lambda expressions isEven: ");
            for (int i = 1; i <= 10; i++)
            {
                if (isEven(i)) Console.WriteLine(i + " is even.");
            }
            Console.WriteLine();


            IntOperation fact = n =>
            {
                int r = 1;
                for (int i = 1; i <= n; i++)
                    r = i * r;
                return r;
            };
            Console.WriteLine("Factorial 3 is equals " + fact(3));
            Console.WriteLine("Factorial 5 is equals " + fact(5));
            Console.WriteLine();

            Event evt = new Event();
            EventHandler firstEvent = (sender, args) => Console.WriteLine("First event has happend.");
            EventHandler secondEvent = (sender, args) => Console.WriteLine("Second event has happend.");
            EventHandler thirdEvent = (sender, args) => Console.WriteLine("Third event has happend.");
            EventHandler fourthEvent = (sender, args) => Console.WriteLine("Fourth event has happend.");

            Console.WriteLine("Events adding.");
            evt.SomeEvent += firstEvent;
            evt.SomeEvent += secondEvent;
            evt.SomeEvent += thirdEvent;
            Console.WriteLine();

            Console.WriteLine("Try to add fourth event handler.");
            evt.SomeEvent += fourthEvent;
            evt.OnSomeEvent();
            Console.WriteLine();

            Console.WriteLine("Removing of first event handler.");
            evt.SomeEvent -= firstEvent;
            evt.OnSomeEvent();
            Console.WriteLine();

            Console.WriteLine("Try to remove first event handler again.");
            evt.SomeEvent -= firstEvent;
            evt.OnSomeEvent();
            Console.WriteLine();

            Console.WriteLine("Adding of fourth event handler.");
            evt.SomeEvent += fourthEvent;
            evt.OnSomeEvent();
        }
    }
}
