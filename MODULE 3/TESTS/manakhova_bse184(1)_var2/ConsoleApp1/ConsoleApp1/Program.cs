/*Манахова Мария
 БПИ184
 Вариант 2
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigSeq
{
    class Program
    {
        static Random rand = new Random();
        static FigureSequence figureSequence = new FigureSequence(rand.Next(-50, 151));

        static void Main(string[] args)
        {

            int n;
            do Console.WriteLine("Введите размер массива (целое число больше нуля)");
            while (!int.TryParse(Console.ReadLine(), out n) || (n <= 0));

           

            
            figureSequence.GetInfo();
            figureSequence.GetMaxCondDensityInfo();
            figureSequence.AverageRectangleArea();
           
        }
    }
}
