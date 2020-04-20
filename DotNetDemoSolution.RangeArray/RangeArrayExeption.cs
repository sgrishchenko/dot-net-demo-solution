
using System;

namespace DotNetDemoSolution.RangeArray
{
    class RangeArrayException : Exception
    {
        public RangeArrayException() : base() { }
        public RangeArrayException(string message) : base(message) { }
        public RangeArrayException(string message, Exception inner) : base(message, inner) { }
        protected RangeArrayException(
        System.Runtime.Serialization.SerializationInfo info,
        System.Runtime.Serialization.StreamingContext context) :
        base(info, context)
        { }

        public override string ToString()
        {
            return Message;
        }
    }
}