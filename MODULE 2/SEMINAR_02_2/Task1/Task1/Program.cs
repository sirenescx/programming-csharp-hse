using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        class Birthday
        {
            string name; // закрытое поле - фамилия
            int year, month, day; // Закрытые поля: год, месяц, день рождения

            public Birthday() : this("Неизвестно")
            {
            }

            public Birthday(string name) : this(name, 1970, 1, 1)
            {
            }

            public Birthday(string name, int y, int m, int d)
            { // Конструктор
                this.name = name;
                year = y; month = m; day = d;
            }

            DateTime Date
            { // закрытое свойство - дата рождения
                get { return new DateTime(year, month, day); }
            }
            
            public void GetInfo()
            {
                Console.WriteLine($"{name}, {day}.{month}.{year}");
            }

            public string Information
            { // свойство - сведения о человеке
                get
                {
                   // return name + ", дата рождения " + Date.ToString("F", new System.Globalization.CultureInfo("ru-RU"));
                    return name + ", дата рождения " + Date.ToString("dd-MM-yy");

                }
            }

            public int HowManyDays
            { // свойство - сколько дней до дня рождения
                get
                {
                    // номер сего дня от начала года:
                    int nowDOY = DateTime.Now.DayOfYear;
                    // номер дня рождения от начала года:
                    int myDOY = Date.DayOfYear;
                    int period = myDOY >= nowDOY ? myDOY - nowDOY :
                    365 - nowDOY + myDOY;
                    return period;
                }
            }
        }

      

        static void Main()
        {
             Birthday md = new Birthday("Чапаев", 1887, 2, 9);
             Console.WriteLine(md.Information);
             Console.WriteLine("До следующего дня рождения дней осталось: ");
             Console.WriteLine(md.HowManyDays);
             Birthday km = new Birthday("Маркс Карл", 1818, 5, 4);
             Console.WriteLine(km.Information);
             Console.WriteLine("До следующего дня рождения дней осталось: ");
             Console.WriteLine(km.HowManyDays); 


        }
}
}
