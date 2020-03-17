using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_03
{
    public interface IFigure
    {
        double Area { get; }
    }

    public class Square : IFigure
    {
        double A { get; set; }
        public Square(double a)
        {
            A = a;
        }
        public double Area { get => A * A; }

        public override string ToString() => $"Class Square. a = {A}, S = {Area}.";

    }

    public class Circle : IFigure
    {
        double R { get; set; }
        public Circle(double r)
        {
            R = r;
        }

        public double Area { get => Math.PI * R * R; }

        public override string ToString() => $"Class Circle. r = {R}, S = {Area}.";
    }
    class Program
    {
        public static void PrintInfo<T>(T[] arr, double maxValue) where T : IFigure
        {
            foreach (var item in arr)
            {
                if (item.Area > maxValue)
                    Console.WriteLine(item.ToString());
            }
        }
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Random Rnd = new Random();
                const int Dim = 7;
                Circle[] MassCircles = new Circle[Dim];
                Square[] MassSquares = new Square[Dim];
                for (int i = 0; i < Dim; i++)
                {
                    MassCircles[i] = new Circle(Rnd.Next(10));
                    MassSquares[i] = new Square(Rnd.Next(10));
                }
                PrintInfo<Circle>(MassCircles, 30);
                PrintInfo<Square>(MassSquares, 4);
                Console.WriteLine("Нажмите Enter для повтора, любую другую клавишу для выхода.");
            } while (Console.ReadKey().Key == ConsoleKey.Enter);
        }
    }
}
