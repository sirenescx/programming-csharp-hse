using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        static Random rand = new Random();

        public static void Swap(ref Triangle a, ref Triangle b)
        {
            Triangle temp;
            temp = a;
            a = b;
            b = temp;
        }

        public static void SortArray(ref Triangle[] triangles)
        {

            for (int i = 0; i < triangles.Length - 1; i++)
            {
                for (int j = i + 1; j < triangles.Length; j++)
                if (triangles[i].Square < triangles[j].Square)
                        Swap(ref triangles[i], ref triangles[j]);
            }
        } 
        static void Main(string[] args)
        {
            Triangle[] triangles = new Triangle[rand.Next(5, 16)];
            for (int i = 0; i < triangles.Length; i++)
            {
                Point A = new Point(rand.Next(-10, 10) + rand.NextDouble() * (1 - double.Epsilon),
                    rand.Next(-10, 10) + rand.NextDouble() * (1 - double.Epsilon));
                Point B = new Point(rand.Next(-10, 10) + rand.NextDouble() * (1 - double.Epsilon),
                    rand.Next(-10, 10) + rand.NextDouble() * (1 - double.Epsilon));
                Point C = new Point(rand.Next(-10, 10) + rand.NextDouble() * (1 - double.Epsilon),
                    rand.Next(-10, 10) + rand.NextDouble() * (1 - double.Epsilon));
                triangles[i] = new Triangle(A, B, C);
                Console.WriteLine($"P_{i} = {triangles[i].Perimeter:f3}, S_{i} = {triangles[i].Square:f3}");
            }

            SortArray(ref triangles);

            Console.WriteLine("");
            Console.WriteLine("Sorted Array: ");

            for (int i = 0; i < triangles.Length - 1; i++)
            {
                Console.WriteLine($"P_{i} = {triangles[i].Perimeter:f3}, S_{i} = {triangles[i].Square:f3}");
            }
        }
    }
}
