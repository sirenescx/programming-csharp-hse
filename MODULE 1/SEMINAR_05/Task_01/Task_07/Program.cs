using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_07
{
    class Program
    {

        public static char[] GetDigits(int number)
        {
            int len = (int)Math.Log10(number) + 1; // количество цифр числа
            char[] digits = new char[len]; // массив для хранения цифр
            int figure, i = len - 1;
            do
            { // выделяем цифры числа и помещаем в массив
                figure = number % 10;
                number = number / 10;
                digits[i--] = (char)(figure + '0');
            }
            while (number != 0);
            return digits;
        }

     /*   static void ArrFromN(ref char[] a, int n)
        {
            int i = 0;
            while (n != 0)
            {
                a[i] = (char)(n % 10 + '0');
                n /= 10;
                i++;
            }
        } */

        static void Main(string[] args)
        {
            /* int n;
             do Console.WriteLine("Please enter an integer number > 0: ");
             while (!int.TryParse(Console.ReadLine(), out n) || (n < 0));
             char[] a = new char[(n.ToString()).Length];
             ArrFromN(ref a, n);
             Array.Reverse(a);
             for (int i = 0; i < a.Length; i++)
             Console.Write("{0,4}", a[i]);
             Console.ReadLine(); */

            int number;
            do Console.Write("Введите целое положительное число: ");
            while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
            char[] ciphers = GetDigits(number);
            Console.Write("Цифры числа: ");
            foreach (char ch in ciphers)
            Console.Write(" " + ch);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
