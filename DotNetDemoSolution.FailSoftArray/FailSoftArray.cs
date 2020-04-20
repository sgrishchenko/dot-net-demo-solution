using System;

namespace DotNetDemoSolution.FailSoftArray
{
    class FailSoftArray
    {
        int[] a;
        public int Length { get; private set; }
        public bool Error { get; private set; }

        public FailSoftArray(int size)
        {
            a = new int[size];
            Length = size;
        }

        public int this[int index]
        {
            get
            {
                if (ok(index))
                {
                    Error = false;
                    return a[index];
                }
                else
                {
                    Error = true;
                    return 0;
                }
            }
            set
            {
                if (ok(index))
                {
                    a[index] = value;
                    Error = false;
                }
                else
                {
                    Error = true;
                }
            }
        }

        public int this[double index]
        {
            get
            {
                int intIndex = (int)Math.Round(index);
                return this[intIndex];
            }
            set
            {
                int intIndex = (int)Math.Round(index);
                this[intIndex] = value;
            }
        }

        private bool ok(int index)
        {
            return index >= 0 && index < Length;
        }
    }
}