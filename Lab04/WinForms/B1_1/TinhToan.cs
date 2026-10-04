using System;
using System.Collections.Generic;
using System.Text;

namespace WinForms
{
    public class TinhToan
    {
        public double a { get; set; }
        public double b { get; set; }

        public TinhToan(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public TinhToan()
        {
            this.a = 0;
            this.b = 0;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
        public double Subtract(double a, double b)
        {
            return a - b;
        }
        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return a / b;
        }
    }
}
