using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = new string[] { "нуль", "один", "два",
                                            "три", "четыре",
                                            "пять", "шесть", "семь", "восемь",
                                            "девять", "десять" };

            foreach (string s in lines)
                Console.Write(s + " ");

            int len = lines.Length;
            int[] index = new int[len]; // Массив индексов
            for (int i = 0; i < len; i++)
                index[i] = i;

            for (int i = 0; i < len - 1; i++)
                for (int j = i + 1; j < len; j++)
                    if (lines[index[i]].Length > lines[index[j]].Length)
                    {
                        int temp = index[i];
                        index[i] = index[j];
                        index[j] = temp;
                    }

            Console.WriteLine();
            foreach (int n in index)
                Console.Write(lines[n] + " ");
        }
    }
}
