using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Task_02
{
    class IntegerListTest
    {
        private static IntegerList _list = new IntegerList(10);

        public static void Dispatch(int choice)
        {
            switch (choice)
            {
                case 0:
                    Console.WriteLine("Пока!");
                    break;
                case 1:
                    Console.WriteLine("Какой размер будет у списка?");
                    int size = int.Parse(Console.ReadLine());
                    _list = new IntegerList(size);
                    _list.Randomize();
                    break;
                case 2:
                    _list.Print();
                    Console.WriteLine("Remove First 4");
                    Console.WriteLine("Remove All 5");
                    _list.RemoveFirst(4);
                    _list.RemoveAll(5);
                    _list.Print();
                    break;
                case 3:
                    Console.WriteLine("Какой элемент вы хотите добавить");
                    int newVal = int.Parse(Console.ReadLine());
                    _list.AddElement(newVal);
                    break;

                default:
                    Console.WriteLine("Извините, вы выбрали что-то не то");
                    break;
            }
        }

        public static void PrintMenu()
        {
            Console.WriteLine("\n Меню ");
            Console.WriteLine(" ====");
            Console.WriteLine("0: Выйти");
            Console.WriteLine("1: Создать новый список (** сделайте это с самого начала!!**)");
            Console.WriteLine("2: Напечатать список");
            Console.WriteLine("3: Добавить новый элемент");
            Console.Write("\nВведите ваш выбор: ");
        }

    public static void Main()
    {
        PrintMenu();
        int choice = int.Parse(Console.ReadLine());
        while (choice != 0)
        {
            Dispatch(choice);
            PrintMenu();
            choice = int.Parse(Console.ReadLine());
        }
    }
}
}