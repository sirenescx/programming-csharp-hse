using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_hw_1
{
    public delegate void CoordChanged(Dot x);

    public class Dot
    {
        public double x, y;

        public Dot(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public event CoordChanged OnCoordChanged;

        public Random rnd = new Random();

        public void DotFlow(Dot a)
        {
            for (int i = 0; i <= 10; i++)
            {
                a.x = rnd.Next(-10, 10) + rnd.NextDouble();
                a.y = rnd.Next(-10, 10) + rnd.NextDouble();
                if (a.x < 0 & a.y < 0) OnCoordChanged?.Invoke(a);
            }
        }
    }
    class Program
    {
        public static void PrintInfo(Dot a)
        {
            Console.WriteLine($"A({a.x}, {a.y})");
        }

        static void Main(string[] args)
        {

            double xd = double.Parse(Console.ReadLine());
            double yd = double.Parse(Console.ReadLine());
            Dot D = new Dot(xd, yd);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow(D);

        }
    }
}
