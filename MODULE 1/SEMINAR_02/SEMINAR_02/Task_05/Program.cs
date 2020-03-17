using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static void Numerals(uint number, out uint f1, out uint f2, out uint f3)
        {
            f1 = number / 100;
            uint temp = number - f1 * 100;
            f2 = temp / 10;
            f3 = temp - f2 * 10;
        }

        static void Main()
        {
            uint numb = 100,
                 a, b, c;
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                do Console.Write("Введите целое число от 100 до 999: ");
                while (!uint.TryParse(Console.ReadLine(), out numb) || numb < 100 || numb > 999);
                Numerals(numb, out a, out b, out c);
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine("Для выхода нажмите ESC");
            }
        }
    }
}
