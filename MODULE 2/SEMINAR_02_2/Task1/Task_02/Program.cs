using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y) { X = x; Y = y; }
        public Point() : this(0, 0) { } // конструктор умолчания

        public double Ro
        {
            get
            {
                return Math.Sqrt(X * X + Y * Y);
            }
        }       // СВОЙСТВО RO

        public double Fi
        {
            get
            {
                if (X > 0 & Y >= 0) return Math.Atan(Y / X);
                if (X > 0 & Y < 0) return Math.Atan(Y / X) + 2 * Math.PI;
                if (X < 0) return Math.Atan(Y / X) + Math.PI;
                if (X == 0 & Y > 0) return Math.PI / 2;
                if (X == 0 & Y < 0) return 3 * Math.PI / 2;
                if (X == 0 & Y == 0) return 0;
                return 0;
            }
        }       // СВОЙСТВО FI

        public string PointData
        { // СВОЙСТВО
            get
            {
                string maket = "X = {0:F2}; Y = {1:F2}; Ro = {2:F2}; Fi = {3:F2} ";
                return string.Format(maket, X, Y, Ro, Fi);
            }
        }
 
            static void Main()
            {
                Point a, b, c;
                a = new Point(3, 4);
                Console.WriteLine(a.PointData);
                b = new Point(0, 3);
                Console.WriteLine(b.PointData);
                c = new Point();
                double x = 0, y = 0;
                do
                {
                    Console.Write("x = ");
                    double.TryParse(Console.ReadLine(), out x);
                    Console.Write("y = ");
                    double.TryParse(Console.ReadLine(), out y);
                    c.X = x; c.Y = y;
                Console.WriteLine(c.PointData);
                } while (x != 0 | y != 0);
            }
    }
}
