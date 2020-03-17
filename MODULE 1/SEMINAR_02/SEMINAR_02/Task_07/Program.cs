using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {
        public static bool Check(ref bool c, string name)
        {
            int tmp;
            Console.Write($"Введите значение {name}: ", name);
            string str = Console.ReadLine();
            int.TryParse(str, out tmp);
            c = tmp > 0 ? true : false;
            return c;
        }

        public static void Main()
        {
            bool x, y, z;
            x = false;
            y = false;
            z = false;
            Console.WriteLine("Для начала выполнения нажмите ENTER");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Check(ref x, nameof(x));
                Check(ref y, nameof(y));
                Check(ref z, nameof(z));
                Console.WriteLine("!(x&&y||z) = " + !(x && y || z));
                Console.WriteLine("Для выхода нажмите ESC");
            }
        }
    }
}
