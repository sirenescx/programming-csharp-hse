using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    class Program
    {
        static void Main()
        {
            const double R = 10;
            double x, y;
            Console.WriteLine("Для начала выполнения нажмите ENTER");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                do Console.Write("Введите координату x = ");
                while (!double.TryParse(Console.ReadLine(), out x));
                do Console.Write("Введите координату y = ");
                while(!double.TryParse(Console.ReadLine(), out y));
                string report = "Точка лежит ";
                report += x * x + y * y <= R * R ? "внутри круга!" : "вне круга!";
                Console.WriteLine(report);
                Console.WriteLine("Для выхода из программы нажмите ESC");
            }
        }
    }
}
