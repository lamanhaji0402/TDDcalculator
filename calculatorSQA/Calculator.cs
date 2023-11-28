using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorSQA
{
    public class Calculator
    {

        public double add(double a, double b)
        {
            double sum = a + b;
            return sum;
        }
        public int add(int a, int b)
        {
            int sum = a + b;
            return sum;
        }
        public int subtraction(int a, int b)
        {
            int sub = a - b;
            return sub;
        }

        public float division(float a, float b)
        {
            if (b == 0)
            {
                throw new ArgumentException("Cannot divide by zero.", nameof(b));
            }

            float res = a / b;
            return res;
        }

        public double multiply(float a, float b)
        {
            double res = (double)a * (double)b;
            return res;
        }


    }
}
