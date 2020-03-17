using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using task_01;

namespace task_01_pt2
{
    public class ColorsCount
    {
        public ColorsCount(string colorName, int amount)
        {
            this.ColorName = colorName;
            this.Amount = amount;
        }

        public string ColorName { get; set; }
        public int Amount { get; set; }

        public override string ToString() => $"Amount of objects with color {ColorName} is {Amount}";
    }

    class Program
    {

        static ColorPoint GetObj(string s)
        {
            var result = s.Replace("    ", " ").Split(' ');
            ColorPoint colorPoint = new ColorPoint
            {
                x = double.Parse(result[0]),
                y = double.Parse(result[1]),
                color = result[2],
            };
            return colorPoint;
        }
        static void Main(string[] args)
        {
            string path = @"../../../MyTest.txt";
            if (!File.Exists(path))
            {
                Console.WriteLine("Файл \"{0}\" не найден!", path);
                Console.ReadLine(); return;
            }
            // Таймер для профилирования фрагмента кода:
            System.Diagnostics.Stopwatch timer = new System.Diagnostics.Stopwatch();
            timer.Start();
            string newLine;
            int N = 0;
            List<ColorsCount> counts = new List<ColorsCount>();

            List<ColorPoint> list = new List<ColorPoint>();
            // string[] arrData = File.ReadAllLines(path);
            using (StreamReader sr = File.OpenText(path))
            {
                while ((newLine = sr.ReadLine()) != null)
                {
                    ColorPoint cp = GetObj(newLine);
                    list.Add(cp);
                    if (!counts.Exists(x => x.ColorName == cp.color))
                        counts.Add(new ColorsCount(cp.color, 1));
                    else foreach (var item in counts)
                        {
                            if (item.ColorName == cp.color) item.Amount++;
                        }
                    N++;
                }
            }

            foreach (var item in counts.Distinct())
            {
                Console.WriteLine(item);
            }

            timer.Stop();
            Console.WriteLine("Прочитаны {0} строк из файла: \n{1}", N, path);
            Console.WriteLine("Метод: ReadAllLines \nВремя обработки: {0}", timer.Elapsed);
            Console.WriteLine("Время в миллисекундах: {0}", timer.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}
