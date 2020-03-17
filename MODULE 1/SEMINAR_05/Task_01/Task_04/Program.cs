using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void FormArr(int a_0, ref int[] a)                             ///метод для формирования массива
        {
            int i = 0;
            a[0] = a_0;
            while (a[i] != 1)
            {
                a[i + 1] = a[i] % 2 == 0 ? a[i] / 2 : (3 * a[i] + 1);
                i++;
            }
        }

        static void FormateArr(int[] a)                                       ///метод для форматирования массива по строкам
        {
            int i = 0;
            while (a[i] != 0)
            {
                Console.Write($"{i} = {a[i]}   ");
                i++;
                if (i % 5 == 0) Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            int a_0;
            do Console.WriteLine("Введите целое неотрицательное число: ");
            while (!int.TryParse(Console.ReadLine(), out a_0) || (a_0 < 0));
            int[] a = new int[1000];
            FormArr(a_0, ref a);
            FormateArr(a);
            Console.ReadLine();
        }
    }
}
