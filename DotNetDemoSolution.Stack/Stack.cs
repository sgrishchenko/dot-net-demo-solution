using System;

namespace DotNetDemoSolution.Stack
{
    class Stack
    {
        private char[] stack;
        private int top;

        public Stack(int size)
        {
            stack = new char[size];
            top = 0;
        }

        public Stack(Stack sample): this(sample.stack.Length)
        {
            for (int i = 0; i < sample.top; i++)
                stack[i] = sample.stack[i];

            top = sample.top;
        }

        public void Push(char character)
        {
            if (top == stack.Length)
            {
                Console.WriteLine(" - Stack is full.");
                return;
            }
            stack[top] = character;
            top++;
        }

        public char Pop()
        {
            if (top == 0)
            {
                Console.WriteLine(" - Stack is empty.");
                return (char)0;
            }
            top--;
            return stack[top];
        }

        public bool IsFull()
        {
            return top == stack.Length;
        }

        public bool IsEmpty()
        {
            return top == 0;
        }

        public int Capacity()
        {
            return stack.Length;
        }

        public int GetNum()
        {
            return top;
        }
    }
}