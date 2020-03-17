using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_05
{
    public class Interval
    {
        public double start, end;

        public Interval(double start, double end)
        {
            if (start > end) throw new ArgumentException("Левый конец больше правого.");
            this.start = start;
            this.end = end;
        }

        public Interval(Interval obj)
        {
            if (obj == null) throw new ArgumentNullException("Попытка копировани пустого объекта.");
            this.start = obj.start;
            this.end = obj.end;
        }

        public double Length { get => Math.Abs(this.end - this.start); }

        public static Interval operator +(Interval i1, Interval i2)
        {
            return new Interval(i1.start + i2.start, i1.end + i2.end);
        }
        public static Interval operator -(Interval i1, Interval i2)
        {
            return new Interval(i1.start - i2.start, i1.end - i2.end);
        }

        public static Interval operator *(Interval i1, Interval i2)
        {
            var coords = new double[] { i1.start * i1.end, i2.start * i2.end, i1.start * i2.end, i1.end * i2.start };
            return new Interval(coords.Min(), coords.Max());
        }

        public static Interval operator /(Interval i1, Interval i2)
        {
            if ((i2.start < 0 & i2.end < 0) | (i2.start > 0 & i2.end < 0)) throw new ArgumentException($"0 не должен принадлежать интервалу [{i2.start}, {i2.end}].");
            var coords = new double[] { i1.start / i2.start, i1.start / i2.end, i1.end / i2.start, i1.end / i2.end };
            return new Interval(coords.Min(), coords.Max());
        }

        public override string ToString() => $"[{start}, {end}], длина = {Length}";
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Interval A = new Interval(3, 3);
                Interval B = new Interval(2, 4);
                Console.WriteLine(A);
                Console.WriteLine(B);
                Console.WriteLine(A * B);
                Console.WriteLine(A / B);
                Console.WriteLine(A + B);
                Console.WriteLine(A - B);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }
            Console.ReadKey();
        }
    }
}
