/* Дисциплина: "Программирование"
   Группа: 101ПИ/1
   Студент: Иванов Иван
   Дата: 01.09.2016
   Задача: Написать программу, циклически сдвигающую в алфавите введенный с клавиатуры
   символ латинской строчной буквы на 4 позиции.
 */
using System;

class Program
{
    public static bool Shift(ref char ch)
    {
        if (!(ch >= 'a' && ch <= 'z'))
        {
            return false;
        }
        ch = (char)((ch - 'a' + 4) % 26 + 'a');
        return true;
    }

    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Введите символ:");
            string str;
            while ((str = Console.ReadLine()).Length > 1)
            {
                Console.WriteLine("Ошибка ввода! Введите символ заново:");
            }
            char ch = Convert.ToChar(str);

            if (Shift(ref ch))
            {
                Console.WriteLine(ch);
            }
            else
            {
                Console.WriteLine("Некорректное значение символа.");
            }

            Console.WriteLine("Для выхода из программы нажмите Escape, " +
                              "для продолжения – любую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}