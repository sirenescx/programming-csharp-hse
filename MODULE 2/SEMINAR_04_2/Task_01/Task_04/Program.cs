using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int N1, N2, N3;
            N1 = rand.Next(3, 5);
            N2 = rand.Next(3, 5);
            N3 = rand.Next(3, 5);
            Shape[] shapes = new Shape[N1 + N2 + N3];
            for (int i = 0; i < shapes.Length; i++)
            {
                if (N1 > 0)
                {
                    shapes[i] = new Circle(rand.Next(0, 20));
                    N1--;
                }
                else if (N2>0)
                {
                     shapes[i] = new Cylinder(rand.Next(0, 20), rand.Next(0, 20));
                     N2--;
                }
                else
                    shapes[i] = new Sphere(rand.Next(0, 20));
                if (shapes[i] is Circle) Console.WriteLine($"S(Circle) = {shapes[i].Area():f3}");
                else
                    if (shapes[i] is Cylinder) Console.WriteLine($"S(Cylinder) = {shapes[i].Area():f3}");
                else 
                    if (shapes[i] is Sphere) Console.WriteLine($"S(Sphere) = {shapes[i].Area():f3}");
            }
        }
    }
}
