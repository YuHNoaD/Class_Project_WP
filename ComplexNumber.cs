using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNumber
{
    internal class ComplexNumber
    {
        // property Real
        public int Real
        {
            get { return real; }
            set { real = value; }

        } // end property Real

        // property Imaginary
        public int Imaginary
        {
            get { return imaginary; }
            set { imaginary = value; }

        } // end property Imaginary


        private int real;
        private int imaginary;

        // default constructor
        public ComplexNumber() { }

        // constructor

        public ComplexNumber(int a, int b)
        {
            Real = a;
            Imaginary = b;
        }

        // overload the addition operator
        public static ComplexNumber operator +(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(
                x.Real + y.Real, x.Imaginary + y.Imaginary);
        }

        public static ComplexNumber Add(ComplexNumber x, ComplexNumber y)
        {
            return x + y;
        }

        // overload the subtraction operator
        public static ComplexNumber operator -(ComplexNumber x, ComplexNumber y)
        {
            return new ComplexNumber(x.Real - y.Real, x.Imaginary - y.Imaginary);
        }

        // overload the multiplication operator
        public static ComplexNumber operator *(ComplexNumber x, ComplexNumber y)
        {
            // Công thức: (a+bi)(c+di) = (ac-bd) + (ad+bc)i
            int r = x.Real * y.Real - x.Imaginary * y.Imaginary;
            int i = x.Real * y.Imaginary + x.Imaginary * y.Real;
            return new ComplexNumber(r, i);
        }

        public override string ToString()
        {
            // Định dạng cách hiển thị số phức trên màn hình
            return string.Format("({0} + {1}i)", Real, Imaginary);
        }
    }
}
