using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{

    using System;
    class MyExample
    {
        public static double Square(double r, out double len)
        {
            len = 2 * Math.PI * r;
            return Math.PI * r * r;
        } //Конец определения Square()


        public static void Main()
        {
            double r, //радиус
            s, // площадь круга
            c; // длина окружности
            string str; // Рабочая строка для ввода и вывода данных

            while (Console.ReadLine() != "Нет")
            {
                do
                {
                    Console.Write("Введите радиус: ");
                    str = Console.ReadLine(); //Читаем символьную строку
                } while (!double.TryParse(str, out r)); // Преобразуем в число

                s = Square(r, out c);
                str = $"площадь = {s:f3}, длина = {c:f3}";
                Console.WriteLine(str); // выводим строку с результатом
                Console.WriteLine("Хотите продожить? ДЛя продолжения введите Enter, иначе введите Нет");
            } //Конец определения Main()
        }
    } //Конец объявления MyExample







        }
