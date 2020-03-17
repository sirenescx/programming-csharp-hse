using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class MathFunction
    {
        public double Xmin { get; set; }
        public double Xmax { get; set; }

        public double this[double x]
        {
 
            get
            {
                return Math.Sin(x);
            }
        }

        public double Integral()
        {
            double res = 0, pos = Xmin;
            while (pos < Xmax)
            {
                if (pos + 00.1 < Xmax)
                {
                    res += (this[pos] + this[pos + 0.01]) / 2 * 0.01;
                    pos += 0.01;
                }
                else
                {
                    res += (this[pos] + this[Xmax]) / 2 * (Xmax - pos);
                    pos = Xmax;
                }
            }
            return res;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MathFunction x = new MathFunction();
            x.Xmin = 0;
            x.Xmax = Math.PI;
            Console.WriteLine(x.Integral());
        }
    }
}
