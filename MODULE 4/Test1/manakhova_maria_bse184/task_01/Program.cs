using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_01
{
    class Program
    {
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            int N; 
            do
            {
                Console.WriteLine("Введите количество чисел (целое число больше нуля):");
            } while (!int.TryParse(Console.ReadLine(), out N) || N < 0);

            using (StreamWriter sw = new StreamWriter("../../../input.txt"))
            {
                for (int i = 0; i < N; i++)
                {
                    sw.WriteLine(rnd.Next(0, 1000));
                }
            }
        }
    }
}
