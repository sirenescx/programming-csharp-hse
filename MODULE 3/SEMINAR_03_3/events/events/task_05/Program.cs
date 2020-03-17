using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            TwoDimensionsArrayClass twoDimensionsArray = new TwoDimensionsArrayClass();
            twoDimensionsArray.newItemFilled += TwoDimensionsArrayClass.SumOfArray;
            twoDimensionsArray.lineComplete += () => Console.WriteLine();

            int[,] myArray = new int[4, 5];
            twoDimensionsArray.FillArray(myArray);

            Console.WriteLine("Print():");
            twoDimensionsArray.PrintArray(myArray);

            Console.WriteLine("\nSorting:");

            Random ran = new Random(55);
            int[] ar = new int[19999];
            for (int i = 0; i < ar.Length; i++)
                ar[i] = ran.Next();
            Sorting run = new Sorting(ar);
            View watch = new View();    // Создан объект
            run.onSort += new SortHandler(Display.BarShow);
            run.onSort += new SortHandler(watch.nShow);
            run.Sort();
            Console.Write("\n");

        }
    }
}
