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
            double budget, sum;
            int game_budget;
            do
            {
                Console.WriteLine("Введите бюджет пользователя: ");
                double.TryParse(Console.ReadLine(), out budget);
                do Console.WriteLine("Введите процент бюджета, выделенного на компьютерные игры: ");
                while (!int.TryParse(Console.ReadLine(), out game_budget));
                sum = (game_budget * budget * 0.01);
                Console.WriteLine("Сумма выделенная на игры: ");
                Console.WriteLine($"{sum:C}");
                Console.WriteLine("Нажмите Escape для выхода или любую клавишу для продолжения");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
