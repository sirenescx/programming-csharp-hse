using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace task_05
{
    public delegate void LineCompleteEvent();
    public delegate void FillItemEvent(int[,] ar);
    public class TwoDimensionsArrayClass
    {
        public event LineCompleteEvent lineComplete;
        public event FillItemEvent newItemFilled;
        public static Random rnd = new Random();
        public void PrintArray(int[,] ar)
        {
            int counter = 0;
            for (int i = 0; i < ar.GetLength(0); i++)
                for (int j = 0; j < ar.GetLength(1); j++, counter++)
                {
                    if (counter == 5)
                    {
                        lineComplete?.Invoke();
                        counter = 0;
                    }
                    Console.Write(ar[i, j] + " ");
                }
        }

        public void FillArray(int[,] ar)
        {
            for (int i = 0; i < ar.GetLength(0); i++)
                for (int j = 0; j < ar.GetLength(1); j++)
                {
                    ar[i, j] = rnd.Next(100, 1000);
                    newItemFilled?.Invoke(ar);
                }
        }

        public static void SumOfArray(int[,] ar)
        {
            int sum = 0;
            for (int i = 0; i < ar.GetUpperBound(0); i++)
                for (int j = 0; j < ar.GetUpperBound(1); j++)
                    sum += ar[i, j];
            Console.WriteLine($"Sum = {sum}");

        }
    }
}