using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static void Sums(uint number, out uint sumEven, out uint sumOdd)
        {
            sumEven = 0;
            sumOdd = 0;
            uint cur, cur2, number2;
            number2 = number / 10;
            while (number != 0)
            {
                cur = number % 10;
                number /= 100;
                sumEven += cur;
            }
            
            while (number2 != 0)
            {
                cur2 = number2 % 10;
                number2 /= 100;
                sumOdd += cur2;
            }
        }

        static void Main()
        {
            uint sumEven, number, sumOdd;
            do Console.WriteLine("Введите натуральное число"); while (!uint.TryParse(Console.ReadLine(), out number));
            Sums(number, out sumEven, out sumOdd);
            Console.WriteLine($"sumEven = {sumEven}, sumOdd = {sumOdd}");
            Console.ReadLine();
        }
    }
}
