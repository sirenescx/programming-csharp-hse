using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    class MyComplex
    {
        public double re, im;
        public MyComplex(double xre, double xim)
        {
            re = xre;
            im = xim;
        }
        public static MyComplex operator --(MyComplex mc)
        {
            mc.re--;
            mc.im--;
            return mc;
        }

        public static MyComplex operator ++(MyComplex mc)
        {
            mc.re++;
            mc.im++;
            return mc;
        }

        public static MyComplex operator +(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re + b.re, a.im + b.im);
        }

        public static MyComplex operator -(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re - b.re, a.im - b.im);
        }

        public static MyComplex operator *(MyComplex a, MyComplex b)
        {
            return new MyComplex(a.re * b.re - a.im * b.im, a.im * b.re + a.re * b.im);
        }

        public static MyComplex operator /(MyComplex a, MyComplex b)
        {
            if (Math.Pow(b.re, 2) + Math.Pow(b.im, 2) == 0) throw new ArithmeticException();
            return new MyComplex((a.re * b.re + a.im * b.im) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2)), (a.im * b.re - a.re * b.im) / (Math.Pow(b.re, 2) + Math.Pow(b.im, 2)));
        }
        public double Mod() { return Math.Abs(re * re + im * im); }
        static public bool operator true(MyComplex f)
        {
            if (f.Mod() > 1.0) return true;
            else return false;
        }
        static public bool operator false(MyComplex f)
        {
            if (f.Mod() <= 1.0) return true;
            else return false;
        }
    }
    class Program
    {
        static void Display(MyComplex cs)
        {
            Console.WriteLine("real=" + cs.re + ", image=" + cs.im);
        }
        static void Main()
        {
            MyComplex c1 = new MyComplex(4, 3.3);
            MyComplex c2 = new MyComplex(2, 0.5);
            Display(c1 + c2);
            Display(c1 - c2);
            Display(c1 * c2);
            try
            {
                Display(c1 / c2);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Деление на нуль не определено.");
            }
            /* Console.WriteLine("Модуль исходного комплексного числа = " + c1.Mod());
            while (c1)
            {
                Console.Write("c1 => ");
                Display(c1);
                c1--;
            }
            Console.WriteLine("Модуль полученного числа = " +
            c1.Mod());
            Console.WriteLine("Число принадлежит кругу с радиусом 1."); */
            Console.ReadKey();
        }
    }
}
