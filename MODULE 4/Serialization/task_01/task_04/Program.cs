using System;
using ClassLibrary;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Multiple row;  // ссылка на объект класса
            int size = 0;  // размер генеральной совокупности
            do Console.Write("Введите размер генеральной совокупности: ");
            while (!int.TryParse(Console.ReadLine(), out size) | size < 1);
            Random gen = new Random(5);
            int[] data = new int[size];    // генеральная совокупность
            List<int> dataList = new List<int>(size);
            for (int i = 0; i < size; i++)
            {
                var x = gen.Next(0, 100);
                dataList.Add(x);
                Console.Write(x + " ");
                // data[i] = gen.Next(0, 100);
                // Console.Write(data[i] + "  ");
            }
            Console.WriteLine();

            // BinaryFormatter formBin = new BinaryFormatter();
            XmlSerializer formXml = new XmlSerializer(typeof(Multiple));

            /* using (FileStream byteStream = new FileStream("bytes.dat", FileMode.Create, FileAccess.ReadWrite))
            {
                do
                {  // цикл для создания и записи в файл объектов
                    int div;
                    do
                    {    // цикл проверки делителя!
                        do Console.Write("Введите делитель: ");
                        while (!int.TryParse(Console.ReadLine(), out div));
                        try
                        {
                            //row = new Multiple(div, data);
                            row = new Multiple(div, dataList);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Нужен делитель от 1 до 9!");
                            continue;
                        }
                    }
                    while (true);
                    // создан объект row, запишем его код в файл:
                    formBin.Serialize(byteStream, row);
                    byteStream.Flush();
                    Console.WriteLine("\nДля чтения файла - клавиша ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
                byteStream.Position = 0;
                while (true) // читать до конца файла 
                    try
                    {
                        row = (Multiple)formBin.Deserialize(byteStream);
                        Console.WriteLine(row.ToString());
                    }
                    catch (SerializationException)
                    { // 
                        break;
                    }
            } */


            int div;
            do Console.Write("Введите делитель: ");
            while (!int.TryParse(Console.ReadLine(), out div));

            using (FileStream fileStream = new FileStream("xml.ser", FileMode.Create))
            {
                do
                {
                    try
                    {
                        row = new Multiple(div, dataList);
                        formXml.Serialize(fileStream, row);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        fileStream.Flush();
                    }
                    Console.WriteLine("\nДля чтения файла - клавиша ESC");
                } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            }

            using (FileStream fileStreamDes = new FileStream("xml.ser", FileMode.Open))
            {
                try
                {
                    row = (Multiple)formXml.Deserialize(fileStreamDes);
                    Console.WriteLine(row);
                }
                catch (SerializationException)
                {
                    fileStreamDes.Close();
                }
            }
            Console.ReadKey();
        }
    }
}
