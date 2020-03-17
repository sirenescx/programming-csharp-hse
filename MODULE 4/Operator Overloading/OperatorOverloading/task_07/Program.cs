using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_07
{
    public class Money
    {
        double rubles;
        double kopecks;
        public Money(double rubles, double kopecks)
        {
            this.rubles = rubles;

            if (kopecks > 100)
            {
                int addRubles = (int)(kopecks / 100);
                this.rubles += addRubles;
                this.kopecks = kopecks - addRubles * 100;
            }
            else
                this.kopecks = kopecks;

            if (kopecks < 0)
            {
                this.rubles --;
                this.kopecks = Math.Abs(kopecks);
            }

            if (rubles % 1 != 0)
            {
                this.rubles -= rubles - (int)rubles;
                this.kopecks += (rubles - (int)rubles) * 100;
            }

            if (this.kopecks % 1 != 0)
                this.kopecks = Math.Round(this.kopecks);

        }


        public Money(Money sum)
        {
            this.rubles = sum.rubles;
            this.kopecks = sum.kopecks;
        }

        public Money TransferCost(double comissionPercent)
        {
            return new Money(this.rubles * (1 + comissionPercent / 100), this.kopecks * (1 + comissionPercent / 100));
        }

        public static Money operator +(Money sum1, Money sum2)
        {
            return new Money(sum1.rubles + sum2.rubles, sum1.kopecks + sum2.kopecks);
        }

        public static Money operator -(Money sum1, Money sum2)
        {
            return new Money(sum1.rubles - sum2.rubles, sum1.kopecks - sum2.kopecks);
        }

        public static Money operator *(Money sum, double x)
        {
            return new Money(sum.rubles * x, sum.kopecks * x);
        }

        public static Money operator /(Money sum, double x)
        {
            if (x == 0) throw new ArgumentException("Деление на нуль не определено");
            return new Money(sum.rubles / x, sum.kopecks / x);
        }

        public override string ToString() => $"{rubles} руб. {kopecks} коп.";

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Money sum1 = new Money(11, 15);
                Money sum2 = new Money(3, 278);
                Console.WriteLine("Введенная сумма 1:\t" + sum1);
                Console.WriteLine("Введенная сумма 2:\t" + sum2);
                Console.WriteLine("Сумма 1 и 2:\t\t" + (sum1 + sum2));
                Console.WriteLine("Разность 1 и 2:\t\t" + (sum1 - sum2));
                Console.WriteLine("Комиссия на 1 в 7%:\t" + sum1.TransferCost(7));
                Console.WriteLine("Умножение 1 на 4.2:\t" + sum1 * 4.2);
                Console.WriteLine("Деление 1 на 2:\t\t" + sum1 / 2);
            }
            catch (ArgumentException ex) { Console.WriteLine(ex.Message); }

            Console.ReadKey();
        }
    }
}
