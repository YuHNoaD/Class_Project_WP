using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complex
{
    public class ComplexNumber
    {
        private int real;
        private int imaginary;

        public ComplexNumber() { }

        public ComplexNumber(int a, int b)
        {
            Real = a;
            Imaginary = b;
        }

        public int Real
        {
            get { return real; }
            set { real = value; }
        }

        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }
        }

        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real + y.Real, x.Imaginary + y.Imaginary);
        }

        public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)
        {
            return x + y;
        }

        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        public static ComplexNumber Subtract(ComplexNumber x, ComplexNumber y)
        {
            return x - y;
        }

        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real * y.Real - x.Imaginary * y.Imaginary,
                                     x.Real * y.Imaginary + x.Imaginary * y.Real);
        }

        public static ComplexNumber Multiply(ComplexNumber x, ComplexNumber y)
        {
            return x * y;
        }

        public override string ToString()
        {
            if (Imaginary >= 0)
                return $"({Real} + {Imaginary}i)";
            else
                return $"({Real} - {Math.Abs(Imaginary)}i)";
        }
    }
}