using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Fraction
    {
        int num; //.. числитель
        int den; //.. знаменатель
        public Fraction(int n, int d)
        { // Конструктор
            if (n >= 0 && d > 0) { num = n; den = d; return; }
            if (n >= 0 && d < 0) { num = -n; den = -d; return; }
            if (n <= 0 && d > 0) { num = n; den = d; return; }
            if (n <= 0 && d < 0) { num = -n; den = -d; return; }
            Console.WriteLine("Нулевой знаменатель: {0}/{1}", n, d);
            return;
        }
        public override string ToString()
        {
            return String.Format("{0}/{1}", num, den);
        }

        public static Fraction operator ++(Fraction fr)
        {
            return new Fraction(fr.num + fr.den, fr.den);
            // fr.num += fr.den;
            // return fr;
        }

        public static Fraction operator --(Fraction fr)
        {
            return new Fraction(fr.num - fr.den, fr.den);
            // fr.num -= fr.den;
            // return fr;
        }

        static public Fraction operator -(Fraction fr)
        {
            return new Fraction(-fr.num, fr.den);
        }

        static public Fraction operator +(Fraction fr1, Fraction fr2)
        {
            return new Fraction(fr1.num * fr2.den + fr2.num * fr1.den, fr1.den * fr2.den);
        }

        static public bool operator <(Fraction fr1, Fraction fr2)
        {
            return (fr1.num * fr2.den < fr1.den * fr2.num);
        }

        public static bool operator >(Fraction fr1, Fraction fr2)
        {
            return (fr1.num * fr2.den > fr2.num * fr1.den);
        }

        // перегруженные операции
    }// End of class Fraction
}
