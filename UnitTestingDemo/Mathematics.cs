using System;

namespace UnitTestingDemo
{
    public class Mathematics
    {
        public int Multiply(int x, int y)
        {
            return x * y;
        }

        public decimal Divide(decimal x, decimal y)
        {
            //if (x == 0 || y == 0)
            //{
            //    throw new ArgumentException("One or both of the arguments are zero");
            //}

            return x / y;
        }
    }
}