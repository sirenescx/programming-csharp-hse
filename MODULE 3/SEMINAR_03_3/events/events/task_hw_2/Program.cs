using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_hw_2
{
    public delegate void SquareSizeChanged(double x);
    class Square
    {
        private double ydr;
        private double xul;
        private double yul;
        private double xdr;

        public Square(double xul, double yul, double xdr, double ydr)
        {
            this.Xul = xul;
            this.Yul = yul;
            this.Xdr = xdr;
            this.Ydr = ydr;
        }

        public double Xul { get => xul; set { xul = value; OnSizeChanged?.Invoke(xul); } }
        public double Yul { get => yul; set { yul = value; OnSizeChanged?.Invoke(yul); } }
        public double Xdr { get => xdr; set { xdr = value; OnSizeChanged?.Invoke(xdr); } }
        public double Ydr { get => ydr; set { ydr = value; OnSizeChanged?.Invoke(ydr); } }

        public event SquareSizeChanged OnSizeChanged;
    }
    class Program
    {
        public static void SquareConsoleInfo(double a)
        {
            Console.WriteLine($"{a:f2}");
        }

        public static Random rnd = new Random();

        static void Main(string[] args)
        {
            double xdr, ydr, xul, yul;
            xdr = double.Parse(Console.ReadLine());
            ydr = double.Parse(Console.ReadLine());
            xul = double.Parse(Console.ReadLine());
            yul = double.Parse(Console.ReadLine());
            Square square = new Square(xul, yul, xdr, ydr);
            square.OnSizeChanged += SquareConsoleInfo;

            for (int i = 0; i <= 5; i++)
            {
                square.Xdr = rnd.Next(-10, 10) + rnd.NextDouble();
                square.Ydr = rnd.Next(-10, 10) + rnd.NextDouble();
                square.Xul = rnd.Next(-10, 10) + rnd.NextDouble();
                square.Yul = rnd.Next(-10, 10) + rnd.NextDouble();
            }
        }
    }
}
