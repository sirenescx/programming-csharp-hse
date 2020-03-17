using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_04
{
    class Program
    {
        public static Random gen = new Random();
        static void Main(string[] args)
        {
            double Sum = 0;
            int count = 0;
            FileInfo file = new FileInfo(@"..\..\Целые_числа");
            FileStream fs = file.Create();   // создан файл и поток 
            int next,               // Очередное число
                number = 10,        // Общее количество чисел в файле
                pattern = 3;        //  Число, задающее кратность
            byte[] bin = new byte[4];   // Массив байтов для кода целого 

            for (int i = 0; i < number; i++)
            {
                next = gen.Next(1000);
                Sum += next;
                count++;
                Console.Write(next + " "); //числа, попавшие в файл
                bin = BitConverter.GetBytes(next);    // байтовое представление 
                fs.Write(bin, 0, bin.Length);       // запись в файл
            }
            var averageBin = BitConverter.GetBytes(Sum / count);
            Console.WriteLine(Sum / count);
            fs.Write(averageBin, 0, averageBin.Length);
            fs.Flush(); // очистить буфер
            Console.WriteLine(fs.Length);
            fs.Close();
            fs.Dispose();
            
            fs = file.Open(FileMode.Open);

            fs.Position = 0;    // Вернуться в начало файла (потока)
            long lenFs = fs.Length; // Определить размер файла (потока)
            Console.WriteLine(lenFs);
            for (int k = 0; k < (lenFs - 8) / 4; k++)
            {
                fs.Read(bin, 0, bin.Length); // прочитать 4 байта
                var decod = BitConverter.ToInt32(bin, 0); // получить значение

               
                Console.WriteLine("decod=" + decod);
            }
            
            for (int k = (int)(lenFs - 8); k < lenFs - 7; k++)
            {
                fs.Read(averageBin, 0, 8);
                var decodAverage = BitConverter.ToDouble(averageBin, 0);
                Console.WriteLine(decodAverage);
            }
            Console.ReadKey();
        }
    }
}
