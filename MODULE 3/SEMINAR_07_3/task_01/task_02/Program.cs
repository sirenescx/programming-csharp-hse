using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02
{
    public struct Coords
    {
        public double x { get; set; }
        public double y { get; set; }
        public Coords(double x, double y) : this()
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString() => $"x={x};y={y}";
    }

    public class Circle
    {
        Coords center;
        double r;

        public Circle(double r, Coords center)
        {
            this.r = r;
            this.center = center;
        }
        public Circle(double r, double x, double y)
        {
            this.r = r;
            center = new Coords(x, y);
        }

        public Coords Center { get => center; set => center = value; }
        public double R
        {
            get => r;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException("Value of r should be greater or equal 0");
                r = value;
            }
        }

        public override string ToString() => $"{Center.ToString()};r={R:f3}";
    }

    public class Rectangle : IComparable<Rectangle>
    {
        Coords ul, rd;
        double a, b;

        public Coords Ul { get => ul; set => ul = value; }
        public Coords Rd { get => rd; set => rd = value; }

        public Rectangle(Coords ul, Coords rd)
        {
            if (ul.x < rd.x) throw new ArgumentException("Координата Х верхнего левого угла должна быть больше координаты правого нижнего");
            if (ul.y < rd.y) throw new ArgumentException("Координата Y верхнего левого угла должна быть больше координаты правого нижнего");
            this.ul = ul;
            this.rd = rd;
            a = Math.Sqrt(Math.Pow(Ul.y - Rd.y, 2));
            b = Math.Sqrt(Math.Pow(Ul.x - Rd.x, 2));
        }

        public double Square { get => a * b; }

        public int CompareTo(Rectangle anotherRectangle)
        {
            if (this.Square > anotherRectangle.Square) return 1;
            else if (this.Square < anotherRectangle.Square) return -1;
            return 0;
        }

        public override string ToString() => $"Down Right({Rd.x:f3},{Rd.x:f3}); Up Left({Ul.x:f3},{Ul.x:f3}); S = {Square:f3}";
    }
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            /*Circle testCircle = new Circle(0, 0, 4);
            Console.WriteLine(testCircle);
            testCircle.Center = new Coords(1, 1);
            Console.WriteLine(testCircle);
            Circle testCircle2 = new Circle(2, new Coords(2, 2));
            Console.WriteLine(testCircle2); */
            Rectangle[] rectangles = new Rectangle[20];
            for (int i = 0; i < rectangles.Length; i++)
            {
                while (true)
                {
                    try
                    {
                        rectangles[i] = new Rectangle(
                            new Coords(rnd.Next(0, 10) + rnd.NextDouble(), rnd.Next(0, 10) + rnd.NextDouble()),
                            new Coords(rnd.Next(0, 10) + rnd.NextDouble(), rnd.Next(0, 10) + rnd.NextDouble()));
                        break;
                    }
                    catch (ArgumentException)
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine("Array:");
            foreach (var rectangle in rectangles)
            {
                Console.WriteLine(rectangle);
            }

            Array.Sort(rectangles);

            Console.WriteLine("\nSorted array:");

            foreach (var rectangle in rectangles)
            {
                Console.WriteLine(rectangle);
            }

            Console.ReadKey();
        }
    }
}
