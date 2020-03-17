using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class SquareTest
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("..\\..\\magicData.txt");             // читаем все строки файла в массив 
            int lineIndex = 0;            // на какой строке файла находимся 
            int count = 0;             // считаем, на каком мы сейчас квадрате 
            while (lines.Length > lineIndex)
            {
                int size;       // размер квадрата 

               // string[] temp = lines[lineIndex].Trim().Split();

                if (!int.TryParse(lines[lineIndex], out size))
                {
                    Console.WriteLine($"Ошибка при чтении размера квадрата: {lines[lineIndex]} - не число (строка {lineIndex+1})");
                    return;
                }
                if (size == -1)                     // в конце файла ожидается -1 
                    return;

                lineIndex++;

                Square square = new Square(size);// TODO: создаём новый квадрат размера size 
                    square.ReadSquare(lines, lineIndex);// TODO: вызываем метод считывания значений элементов квадрата 
                lineIndex += size;
                Console.WriteLine($"\n******** Квадрат номер {++count} ********");
                square.PrintSquare();// TODO: выводим квадрат 
                Console.WriteLine();
                for (int i = 0; i < size; i++)
                    Console.WriteLine($"Сумма по {i} строке = " + square.SumRow(i));// TODO: выводим суммы элементов его строк 
                for (int j = 0; j < size; j++)
                    Console.WriteLine($"Сумма по {j} столбцу = " + square.SumRow(j));// TODO: выводим суммы элементов его столбцов 
                Console.WriteLine("Сумма по главной диагонали = " + square.SumMainDiagonal());// TODO: выводим сумму элементов его главной диагонали 
                Console.WriteLine("Сумма по побочной диагонали = " + square.SumOtherDiagonal());// TODO: выводим сумму элементов его побочной диагонали 
                if (square.Magic() == true) Console.WriteLine("Квадрат магический");
                else Console.WriteLine("Квадрат не магический");// TODO: определяем и выводим, является ли квадрат магическим } 
            }
        }
    }
}
