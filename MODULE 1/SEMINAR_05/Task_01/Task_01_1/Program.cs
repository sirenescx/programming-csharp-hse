using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01_1
{
    class Program
    {

        static void Main(string[] args)
        {
            int numOfItemsA, // количество элементов массива А
            numOfItemsB, // количество элементов массива В
            min = 10, // минимум диапазона значений элементов
            max = 50; // максимум диапазона значений элементов

            do Console.Write("Введите размер массива А: ");
            while (!int.TryParse(Console.ReadLine(), out numOfItemsA) ||
                                                                         numOfItemsA <= 0);
            do Console.Write("Введите размер массива B: ");
            while (!int.TryParse(Console.ReadLine(), out numOfItemsB) ||
                                                                         numOfItemsB <= 0);            int[] a = new int[numOfItemsA + numOfItemsB];
            int[] b = new int[numOfItemsB];

            // Заполняем массивы случайными числами
            Random generatorA = new Random();
            for (int i = 0; i < numOfItemsA; i++)
            {
                a[i] = generatorA.Next(min, max + 1);
                Console.Write("{0,4}", a[i]); // и выводим сразу значения элементов
            }
            Console.WriteLine();

            // Заполняем массивы случайными числами
            Random generatorB = new Random();
            for (int i = 0; i < numOfItemsB; i++)
            {
                b[i] = generatorB.Next(min, max + 1);
                Console.Write("{0,4}",b[i]); // и выводим сразу значения элементов
            }
            Console.WriteLine();
            int k = numOfItemsA; // число элементов в дополненном массиве А
            for (int i = 0; i < b.Length; i++)
                if (b[i] % 2 == 0) a[k++] = b[i];
            // здесь можно создать новый массив с k элементами из А
            int[] result = new int[k];
            Array.Copy(a, result, k); // копирование из а в result k элементов
            for (int i = 0; i < k; i++)
                Console.Write("{0,4}", a[i]);

            Console.ReadLine();
        }
    }
}
