using System;
using System.Collections.Generic;

namespace task_01
{
    public class Point<T> : IComparable<T>
    {
        private T x;
        private T y;
        private IComparable<T> _comparableImplementation;

        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }

        public T X => x;
        public T Y => y;

        public int CompareTo(T other)
        {
            return _comparableImplementation.CompareTo(other);
        }

        public override string ToString()
        {
            return $"{x}, {y}";
        }
    }
    class Program
    {
        public static T Maximum<T>(T a, T b) where T : IComparable<T>
        {
            return Comparer<T>.Default.Compare(a, b) > 0 ? a : b;
        }

        static void Main(string[] args)
        {
            var points = new[]
            {
                new Point<float>(2, 1),
                new Point<float>(-2, -2),
            };

            Array.ForEach(points, Console.WriteLine);

            Console.WriteLine();

            var maxPoint = points[0];
            for (var i = 1; i < points.Length; ++i)
            {
                if (Maximum(points[i - 1].X, points[i].X) > maxPoint.X)
                {
                    maxPoint = points[i];
                }
            }

            Console.WriteLine(maxPoint);

        }
    }
}
