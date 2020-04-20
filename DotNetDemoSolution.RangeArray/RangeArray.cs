using System;

namespace DotNetDemoSolution.RangeArray
{
    class RangeArray
    {

        int[] a;
        int lowerBound;
        int upperBound;
        public int Length { get; private set; }

        public RangeArray(int low, int high)
        {
            if (high < low)
            {
                throw new RangeArrayException("Lower index is less then upper index.");
            }
            Length = high - low + 1;
            a = new int[Length];

            lowerBound = low;
            upperBound = high;
        }
        public int this[int index]
        {

            get
            {
                if (ok(index))
                {
                    return a[index - lowerBound];
                }
                else
                {
                    throw new RangeArrayException("Out of bounds exception.");
                }
            }
            set
            {
                if (ok(index))
                {
                    a[index - lowerBound] = value;
                }
                else
                {
                    throw new RangeArrayException("Out of bounds exception.");
                }
            }
        }

        private bool ok(int index)
        {
            return index >= lowerBound && index <= upperBound;
        }
    }

}