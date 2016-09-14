using System;
using System.Collections.Generic;
using System.Text;

namespace MathLib
{

    public class Complex
    {
        public double re;
        public double im;

        public Complex(double pdReal, double pdImaginary)
        {
            re = pdReal;
            im = pdImaginary;
        }

        public static Complex operator ^(Complex arg1, int arg2)
        {
            int i = 0;
            Complex x = new Complex(0.0, 0.0);

            if (arg2 == 0)
            {
                return x;
            }
            else
            {
                x = arg1;
                for (i = 1; i < arg2; i++)
                {
                    x = x * arg1;
                }
                return x;
            }
        }


        public static Complex operator +(Complex arg1, Complex arg2)
        {
            return (new Complex(arg1.re + arg2.re, arg1.im + arg2.im));
        }

        public static Complex operator -(Complex arg1)
        {
            return (new Complex(-arg1.re, -arg1.im));
        }

        public static Complex operator -(Complex arg1, Complex arg2)
        {
            return (new Complex(arg1.re - arg2.re, arg1.im - arg2.im));
        }

        public static Complex operator *(Complex arg1, Complex arg2)
        {
            return (new Complex(arg1.re * arg2.re - arg1.im * arg2.im, arg1.re * arg2.im + arg2.re * arg1.im));
        }

        public static Complex operator /(Complex arg1, Complex arg2)
        {
            double c1, c2, d;
            d = arg2.re * arg2.re + arg2.im * arg2.im;
            if (d == 0)
            {
                return (new Complex(0, 0));
            }
            c1 = arg1.re * arg2.re + arg1.im * arg2.im;
            c2 = arg1.im * arg2.re - arg1.re * arg2.im;
            return (new Complex(c1 / d, c2 / d));
        }

        public double Abs()
        {
            return (Math.Sqrt(re * re + im * im));
        }

        //Arg of complex number in degrees
        public double Arg()
        {
            double ret = 0;
            if (re != 0)
                ret = (180 / Math.PI) * Math.Atan(im / re);
            return (ret);
           
        }

        

        public override string ToString()
        {
            return (String.Format("Complex: ({0}, {1})", re, im));
        }

        public string ToComplexString(int iRounding)
        {
            string ComplexNumber = Convert.ToString(Math.Round(re, iRounding)) + "+" + Convert.ToString(Math.Round(im, iRounding)) + "i";
            return ComplexNumber;
        }
    }
}
