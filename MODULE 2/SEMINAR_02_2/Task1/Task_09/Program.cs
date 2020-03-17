using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Circle
    {
        double _r;

        public Circle(double r) { _r = r; }

        public Circle() : this(0) { }

        public double S
        {
            get
            {
                return Math.PI * _r * _r;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            double Rmin = 1;
            double Rmax = 5;
            double delta = 0.5;
            double R = Rmin;
            while (R < Rmax)
            {
                Circle Sr = new Circle(R);
                Console.WriteLine($"При R = {R} S = {Sr.S}");
                    R += delta;
            }
        }
    }
}
