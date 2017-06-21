using System;

namespace Calculator
{
    public class SimpleCalculator
    {
        static void Main(string[] args)
        {

        }

        public int Add(int a, int b)
        {
            return a + b;
        }
        public double AddDoubles(double a, double b)
        {
            return a + b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Divide(int value, int by)
        {
            if (value > 100)
            {
                throw new ArgumentOutOfRangeException("by");
            }
            return value/by;
        }
    }
}
