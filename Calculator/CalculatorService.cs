using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class CalculatorService
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Divide(int a, int b)
        {
            return a / b; // namerno bez provere nule
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public int Factorial(int n)
        {
            if (n < 0)
                throw new ArgumentException("n must be >= 0");

            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
