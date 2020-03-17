using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_01
{
    public class ColorPoint
    {
        public static string[] colors = { "Red", "Green", "DarkRed",
            "Magenta", "DarkSeaGreen", "Lime", "Purple", "DarkGreen",
            "DarkOrange", "Black", "BlueViolet", "Crimson", "Gray",
            "Brown", "CadetBlue" };
        public double x, y;
        public string color;
        public new string ToString()
        {
            string format = "{0:F3}    {1:F3}    {2}";
            return string.Format(format, x, y, color);
        }
    }

    class Program
    {
        static Random gen = new Random();
        public static void Main()
        {
            int N; // Количество создаваемых объектов (число строк в файле)
            string path = @"../../../MyTest.txt";
            while (!int.TryParse(Console.ReadLine(), out N) || N < 0)
                Console.WriteLine("Amount of strings in file should be integer number > 0");
            List<ColorPoint> list = new List<ColorPoint>();
            ColorPoint one;
            for (int i = 0; i < N; i++)
            {
                one = new ColorPoint
                {
                    x = gen.NextDouble(),
                    y = gen.NextDouble()
                };
                int j = gen.Next(0, ColorPoint.colors.Length);
                one.color = ColorPoint.colors[j];
                list.Add(one);
            }
            string[] arrData = Array.ConvertAll(list.ToArray(), (ColorPoint cp) => cp.ToString());
            // Запись массива стpок в текстовый файл:         
            File.WriteAllLines(path, arrData);
            Console.WriteLine("Записаны {0} строк в текстовый файл: \n{1}", N, path);

        }
    }
}
