using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
   public class Complex
    {
        double _re;
        double _im;

        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }

        public Complex(Complex ob)
        {
            _re = ob._re;
            _im = ob._im;
        }

        public Complex() : this(0, 0) { }

        public double Re
        {
            get
            {
                return _re;
            }
        }

        public double Im
        {
            get
            {
                return _im;
            }
        }

        public static double Abs(Complex c)
        {
            return Math.Sqrt(c._re * c._re + c._im * c._im);
        }

        public static double Arg(Complex c)
        {
            return Math.Atan2(c._im, c._re);
        }

        public static Complex Sum(Complex x, Complex y)
        {
            Complex Res = new Complex();
            Res._re = x._re + y._re;
            Res._im = x._im + y._im;
            return Res;
        }

        public static Complex Sub(Complex x, Complex y)
        {
            Complex Res = new Complex();
            Res._re = x._re - y._re;
            Res._im = x._im - y._im;
            return Res;
        }

        public static Complex Mult(Complex x, Complex y)
        {
            Complex Res = new Complex();
            Res._re = x._re * y._re - x._im * y._im;
            Res._im = x._im * y._re + x._re * y._im;
            return Res;
        }

        public static Complex Div(Complex x, Complex y)
        {
            Complex Res = new Complex();
            double D = y._re * y._re + y._im * y._im;
            if (D != 0)
            {
                Res._re = (x._re * y._re + x._im * y._im) / D;
                Res._im = (x._im * y._re - x._re * y._im) / D;
                return Res;
            }
            else return null;
        }

        public override string ToString()
        {
            return String.Format($"{Re} + {Im}i");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c = new Complex(4, 3);
            Complex c2 = new Complex(5, 2);
            Console.WriteLine(Complex.Sum(c, c2));
            Console.WriteLine(Complex.Sub(c, c2));
            Console.WriteLine(Complex.Mult(c, c2));
            Console.WriteLine(Complex.Div(c, c2));
            Console.ReadLine();
        }
    }
}
