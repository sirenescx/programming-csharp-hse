/*
 Дисциплина: Программирование
 Группа: БПИ184_1
 Студент: Манахова Мария
 Дата: 28.09.2018
 Вариант 13: 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    
    class Program
    {
      

        static int sum(int n, int m)
        {
            int c, o;
            string s;
            int mpot = 18742;
            if (m == 0) Console.WriteLine($"Остаток от выделенной суммы равен {n}", n);
            else
            {
                c = n / m;
                o = n % m;
                s = c < mpot ? "Кажется корпоратива не будет!" : "Корпоративу быть";
                Console.WriteLine(s);
                Console.WriteLine($"Гонорар каждого члена команды равен {c}", c);
                Console.WriteLine($"Остаток от выделенной суммы равен {o}", o);
            }
            return 0;
        }
        static void Main()
        {
            int n, m;
            do
            {
                Console.WriteLine("Введите выделенную сумму (целое число > 0): ");
                while (!int.TryParse(Console.ReadLine(), out n) || n < 0) Console.WriteLine("Ошибка ввода, введите заново: ");
                Console.WriteLine("Введите количество разработчиков (целое число > 0): ");
                while (!int.TryParse(Console.ReadLine(), out m) || m < 0) Console.WriteLine("Ошибка ввода, введите заново: ");
                sum(n, m);
                Console.WriteLine("Для выхода нажмите ESCAPE, для продолжения любую клавишу");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
