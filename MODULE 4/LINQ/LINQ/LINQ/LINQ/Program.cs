using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static public uint figSum(uint k)
        {
            if (k / 10 == 0) return k;
            return figSum(k / 10) + k % 10;
        }
        // Обобщенная функция печати элементов последовательности:
        static void printSeries<T>(IEnumerable<T> ser)
        {
            var line = ser.Select(x => x.ToString()).
            Aggregate((a, b) => a + "\t" + b);
            Console.WriteLine(line);
        }
        static void Main(string[] args)
        {
            uint[] row = { 123, 31, 14, 0, 9, 10 };
            Console.WriteLine("Исходный массив");
            printSeries(row);
            var result = row.Select(x => figSum(x));
            Console.WriteLine("Сумма цифр элемента массива");
            printSeries(result);

        }
    }
}

