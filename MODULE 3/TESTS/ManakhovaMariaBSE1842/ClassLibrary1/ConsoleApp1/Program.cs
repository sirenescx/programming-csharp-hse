/*
 Манахова Мария
 БПИ188
 Вариант 1*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            ClassLibrary1.Point[] sampleAr = new ClassLibrary1.Point[15];
            for (int i = 0; i < sampleAr.Length; i++)
            {
                sampleAr[i] = new Point(rand.Next(-10, 11), rand.Next(-10, 11));
                Console.WriteLine(sampleAr[i]);
            }

            Point a = null, b = null;

            double min = double.MaxValue;

            for (int i = 0; i < sampleAr.Length; i++)
            {
                for (int j = 0; j < sampleAr.Length; j++)
                {
                    R calculateR = (x, y) => ClassLibrary1.Point.calcR(x, y);
                    if ((calculateR(sampleAr[i], sampleAr[j]) < min) && i != j)
                    {
                        min = calculateR(sampleAr[i], sampleAr[j]);
                        a = sampleAr[i];
                        b = sampleAr[j];
                    }
                }
            }

            Console.WriteLine($"{min}, {a.ToString()}, {b.ToString()}");

            Console.ReadKey();

        }
    }
}
