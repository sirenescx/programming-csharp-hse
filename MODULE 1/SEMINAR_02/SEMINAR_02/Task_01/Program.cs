using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    public static int Un(uint n)
    {
        double b = (1 + Math.Sqrt(5)) / 2;
        double un = (Math.Pow(b, n) - Math.Pow(-b, -n)) / (2 * b - 1);
        return (int)(un + 0.5);
    }

    public static void Main(string[] args)
    {
        uint n; // Номер члена ряда
        int res; // Целочисленное значение члена
        string line;


        while (Console.ReadLine() != "Нет")
        {
            do
            {
                Console.Write("Введите номер члена ряда: ");
                line = Console.ReadLine();
            } while (!uint.TryParse(line, out n));

            res = Un(n); // Вызов метода
            Console.WriteLine("число Фибоначчи: " + res);
            Console.WriteLine("Хотите продожить? ДЛя продолжения введите Enter, иначе введите Нет");
        }







    } //Конец определения метода Main()
} //Конец объявления класса Program
