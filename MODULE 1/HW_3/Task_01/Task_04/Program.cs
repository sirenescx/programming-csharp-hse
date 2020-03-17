using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static int floor(int aud)
        {
            int x, num;
            x = aud % 100;
            num = aud - x * 100;
            return num;
        }
        static void Main()
        {
            int aud1, aud2, aud3, min_num;
            do
            {
                Console.WriteLine("Введите номер первого кабинета: ");
                int.TryParse(Console.ReadLine(), out aud1);
                Console.WriteLine("Введите номер второго кабинета: ");
                int.TryParse(Console.ReadLine(), out aud2);
                Console.WriteLine("Введите номер третьего кабинета: ");
                int.TryParse(Console.ReadLine(), out aud3);
                min_num = (floor(aud1) > floor(aud2)) ? (floor(aud1) > floor(aud3) ? aud1 : aud3) : aud2;
                Console.WriteLine(min_num);
                Console.WriteLine("Для продолжения нажмите любую клавишу, для выхода нажмите ESCAPE");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
