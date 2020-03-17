using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{

    using System;
    class Program
    {
        static double Total(double k, double r, uint n)
        {
            uint c = 0;
            double temp;
            temp = k;
            while (n > 0)
            {
                temp *= (1 + r * 0.01);
                n --;
                c++;
                Console.WriteLine($"Сумма в конце {c} года равна {temp}");
            }
            return temp;
        }
        static void Main()
        {
            double k, r, s;
            uint n;
            do Console.Write("Введите начальный капитал: ");
            while (!double.TryParse(Console.ReadLine(), out k) || k <= 0); // Капитал не отрицателен
            do Console.Write("Введите годовую процентную ставку: ");
            while (!double.TryParse(Console.ReadLine(), out r) || r <= 0); // Процент не отрицателен
            do Console.Write("Введите число лет: ");
            while (!uint.TryParse(Console.ReadLine(), out n) || n == 0); // число лет не равно нулю
            s = Total(k, r, n); // обращение к методу
            Console.WriteLine("Итоговая сумма: " + s);
            Console.ReadLine();
        } // end of Main()
    } // end of Program
}