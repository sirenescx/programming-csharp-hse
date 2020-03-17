using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_06
{
    public class Polynomial2
    {
        public double a, b, c;

        public Polynomial2(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public Polynomial2(Polynomial2 polynom)
        {
            this.a = polynom.a;
            this.b = polynom.b;
            this.c = polynom.c;
        }

        public double Value(double x)
        {
            return a * Math.Pow(x, 2) + b * x + c;
        }

        public static Polynomial2 operator +(Polynomial2 p1, Polynomial2 p2)
        {
            return new Polynomial2(p1.a + p2.a, p1.b + p2.b, p1.c + p1.c);
        }

        public static Polynomial2 operator -(Polynomial2 p1, Polynomial2 p2)
        {
            return new Polynomial2(p1.a - p2.a, p1.b - p2.b, p1.c - p1.c);
        }

        public static Polynomial2 operator *(Polynomial2 p, double x)
        {
            return new Polynomial2(p.a * x, p.b * x, p.c * x);
        }

        public static Polynomial2 operator /(Polynomial2 p, double x)
        {
            if (x == 0) throw new ArgumentException("Деление на нуль не определено.");
            return new Polynomial2(p.a / x, p.b / x, p.c / x);
        }

        public static Polynomial2 operator /(Polynomial2 p1, Polynomial2 p2)
        {
            if (p2.a == 0) throw new ArgumentException("Полином-делитель не является полиномом второй степени.");
            double p2newA = p1.a / p2.a;
            return new Polynomial2(p1.a - p2.a * p2newA, p1.b - p2.b * p2newA, p1.c - p2.c * p2newA);
        }

        public override string ToString() => $"{a}*x^2 + {b}*x + {c}";

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Polynomial2 p1 = new Polynomial2(2, 3, 4);
                Console.WriteLine(p1);
                Polynomial2 p2 = new Polynomial2(2, 1, 6);
                Console.WriteLine(p2);
                Console.WriteLine(p1 + p2);
                Console.WriteLine(p1 * 4);
                Console.WriteLine(p1 / 4);
                Console.WriteLine(p1 / p2);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }
    }
}
