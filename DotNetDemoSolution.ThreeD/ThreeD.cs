using System;

namespace DotNetDemoSolution.ThreeD
{
    class ThreeD
    {
        int x, y, z;
        public ThreeD()
        {
            x = y = z = 0;
        }

        public ThreeD(int i, int j, int k)
        {
            x = i;
            y = j;
            z = k;
        }

        public static ThreeD operator +(ThreeD op1, ThreeD op2)
        {
            ThreeD result = new ThreeD();
            result.x = op1.x + op2.x;
            result.y = op1.y + op2.y;
            result.z = op1.z + op2.z;
            return result;
        }

        public static ThreeD operator +(ThreeD op1, int op2)
        {
            return op1 + new ThreeD(op2, op2, op2);
        }

        public static ThreeD operator +(int op1, ThreeD op2)
        {
            return op2 + op1;
        }

        public static ThreeD operator -(ThreeD op1, ThreeD op2)
        {
            return op1 + (-op2);
        }

        public static ThreeD operator -(ThreeD op1, int op2)
        {
            return op1 + (-op2);
        }

        public static ThreeD operator -(ThreeD op)
        {
            ThreeD result = new ThreeD();
            result.x = -op.x;
            result.y = -op.y;
            result.z = -op.z;
            return result;
        }

        public static ThreeD operator ++(ThreeD op)
        {
            return op + 1;
        }

        public static ThreeD operator --(ThreeD op)
        {
            return op - 1;
        }

        public double Abs()
        {
            return Math.Sqrt(x * x + y * y + z * z);
        }

        public static bool operator <(ThreeD op1, ThreeD op2)
        {
            return op1.Abs() < op2.Abs();
        }

        public static bool operator >(ThreeD op1, ThreeD op2)
        {
            return op1.Abs() > op2.Abs();
        }

        public static bool operator true(ThreeD op)
        {
            return ((op.x != 0) || (op.y != 0) || (op.z != 0));
        }

        public static bool operator false(ThreeD op)
        {
            return ((op.x == 0) && (op.y == 0) && (op.z == 0));
        }

        public static ThreeD operator |(ThreeD op1, ThreeD op2)
        {
            if (op1) return new ThreeD(1, 1, 1);
            if (op2) return new ThreeD(1, 1, 1);
            return new ThreeD(0, 0, 0);
        }

        public static ThreeD operator &(ThreeD op1, ThreeD op2)
        {
            if (op1)
            {
                if (op2) return new ThreeD(1, 1, 1);
                return new ThreeD(0, 0, 0);
            }
            else
            {
                return new ThreeD(0, 0, 0);
            }
        }

        public static bool operator !(ThreeD op)
        {
            if (op) return false;
            else return true;
        }

        public override string ToString()
        {
            return "(" + x + ", " + y + ", " + z + ")";
        }
    }
}