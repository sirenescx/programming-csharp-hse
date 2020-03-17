using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_08
{
    public class Point
    {
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }
        public int Y { get; set; }
        public double Mod
        {
            get { return Math.Sqrt(X * X + Y * Y); }
        }
        public bool Equals(Point other)
        {
            return (X == other.X & Y == other.Y);
        }

        public override int GetHashCode()
        {
            return this.X.GetHashCode() ^ this.Y.GetHashCode() ^ this.Mod.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format("x = {0}, y = {1}, mod = {2:G5}", X, Y, Mod);
        }
    }

    public class PointList : IEnumerable<Point>
    {
        // Закрытый список для хранения элементов последовательности:
        private List<Point> list;

        public PointList()
        {
            list = new List<Point>();
        }

        public List<Point> List { get => list; set => list = value; }

        public IEnumerator<Point> GetEnumerator()
        {
            list = list.GroupBy(x => new { x.X, x.Y }).Select(y => y.First()).ToList();
            for (Int32 i = 0; i < list.Count; i++)
                yield return list[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Point x)
        {
            list.Add(x);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PointList set = new PointList();
            set.Add(new Point(4, 5));
            set.Add(new Point(4, 5));
            set.Add(new Point(4, 5));
            set.Add(new Point(7, 1));
            set.Add(new Point(7, 2));
            set.Add(new Point(5, 2));
            set.Add(new Point(7, 2));
            Console.WriteLine("Список точек на плоскости:");
            foreach (Point p in set)
                Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
    }
}

