using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program
    {
        static Random rand = new Random();

        static void Main(string[] args)
        {
            int step;
            step = rand.Next(3, 16);
            ArithmeticSequence sequence = new ArithmeticSequence();
            ArithmeticSequence[] arr = new ArithmeticSequence[rand.Next(5, 16)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new ArithmeticSequence(rand.Next(0, 10) + rand.NextDouble() * (1 + double.Epsilon),
                    rand.Next(1, 5) + rand.NextDouble() * (1 + double.Epsilon));
                Console.WriteLine($"Сумма первых {step} членов прогрессии a_{i} = {arr[i].GetSum(step):f3}");
                if (arr[i][step] > sequence[step]) Console.WriteLine(arr[i].ToString());
            }
        }
    }
}
