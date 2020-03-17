using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_10
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Please enter size of the array: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);
            Circle Default = new Circle(6, 8, 10);
            Circle[] circles = new Circle[n];
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle(rand.Next(1, 16), rand.Next(1, 16), rand.Next(1, 16));

                Console.WriteLine(circles[i].ToString() + circles[i].CheckCircles(circles[i], Default) + 
                    " with Default" + Default.ToString());

            }
        }
    }
}
