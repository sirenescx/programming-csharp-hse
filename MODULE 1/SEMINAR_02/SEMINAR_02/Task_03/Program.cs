using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    using System;
    class Program
    {
        public static void ValuesSort(ref int x, ref int y, ref int z)
        {
            // Вспомогательные переменные
            int a1 = 0, a2 = 0, a3 = 0;
            a1 = x < y ? (x < z ? x : z) : (y < z ? y : z);
            a3 = x > y ? (x > z ? x : z) : (y > z ? y : z);
            //a2 = x + y + z - a1 - a3;
            a2 = x < y ? (x > z ? x : (y > z ? z : y)) : (y > z ? y : (x > z ? z : x));
            x = a1; y = a2; z = a3;
        }
        public static void Main()
        {
            int x = 0, y = 0, z = 0;
            string str; // Строка для приёма данных
            while (Console.ReadLine() != "No")
            {
                Console.WriteLine("Введите число x : ");
                str = Console.ReadLine(); //Читаем символьную строку
                int.TryParse(str, out x);
                Console.WriteLine("Введите число y : ");
                str = Console.ReadLine(); //Читаем символьную строку
                int.TryParse(str, out y);
                Console.WriteLine("Введите число z : ");
                str = Console.ReadLine(); //Читаем символьную строку
                int.TryParse(str, out z);
                ValuesSort(ref x, ref y, ref z);
                Console.WriteLine("x = " + x);
                Console.WriteLine("y = " + y);
                Console.WriteLine("z = " + z);
                Console.WriteLine("Хотите продолжить? Нажмите Enter, если да, введите No, если нет ");
            }


        }
    }
}
