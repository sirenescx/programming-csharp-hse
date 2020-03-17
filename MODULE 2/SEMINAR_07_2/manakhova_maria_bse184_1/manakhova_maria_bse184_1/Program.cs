/*
 * Манахова Мария
 * БПИ184
 * Вариант 5
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace manakhova_maria_bse184_1
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        { 
            do
            {
                Square sq = new Square(rand.Next(1, 15) + rand.NextDouble());
                Console.WriteLine(sq.ToString());
                Rectangular rt = new Rectangular(rand.Next(1, 20) + rand.NextDouble(), rand.Next(1, 20) + rand.NextDouble());
                Console.WriteLine(rt.ToString());
                Console.WriteLine("Для выхода ESC, для продолжения любая клавиша");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
