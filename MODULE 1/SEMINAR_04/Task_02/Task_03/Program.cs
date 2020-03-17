/* Дисциплина: "Программирование"
   Группа: 101ПИ/1
   Студент: Иванов Иван
   Дата: 01.09.2016 
   Задача: Написать программу для вывода битового представления 
   введенного положительного целого числа.
 */

using System;

public class Program {
    public static void PrintBitRepresentation(uint number) {
        // Рабочая переменная 
        uint temp,
            // Очередной разряд     
            bit;
        // Величина поразрядного сдвига (степень 2)
        int expo = 0;
        temp = number;

        // Цикл с предусловием
        while (temp >= 1) {
            temp >>= 1;
            expo++;
        }

        temp = number;

        // Цикл с постусловием
        do {
            expo--;
            bit = temp >> expo;
            Console.Write(bit + " ");
            temp -= bit << expo;
        }
        while (expo > 0);
    }
    
    public static void Main() {
        // Введенное число
        uint number;
        do {
            Console.Write("Введите целое положительное число: ");
            while (!uint.TryParse(Console.ReadLine(), out number)) {
                Console.WriteLine("Ошибка ввода! Повторите ввод числа:");
            }

            // Вычисление и печать битового представления числа
            PrintBitRepresentation(number);

            Console.WriteLine("Для выхода из программы нажмите Escape, " +
                              "для продолжения – любую другую клавишу.");
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
    }
}