using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_02
{
    class Program
    {
        public static char CheckSymbol(string s)
        {
            if (s.Length != 1) return '0';
            else
            {
                if (Convert.ToChar(s) >= 'A' & Convert.ToChar(s) <= 'Z')
                    return Convert.ToChar(s);
                else return '0';
            }
        }
        static void Main(string[] args)
        {
            FileInfo fi = new FileInfo(@"../../../Alphabet.txt");
            FileStream fs = fi.Open(FileMode.OpenOrCreate);
            long len = fs.Length;   // Размер файла
            if (len == 26) Console.WriteLine("Aлфавит собран!");
            else
            {
                if (len == 0) Console.WriteLine("Файл пуст!");
                fs.Seek(len, SeekOrigin.Begin);
                byte bt = (byte)((int)'A' + len);
                fs.WriteByte(bt);
                Console.WriteLine("Добавляем в файл букву " + (char)bt);
            }

            char letter;
            Console.WriteLine("Введите букву, которую хотите заменить");
            letter = (CheckSymbol(Console.ReadLine().ToUpper()));

            byte letterByte = (byte)((int)letter);
            Console.WriteLine(letterByte);

            Console.WriteLine("Буквы в файле:");
            fs.Seek(0, SeekOrigin.Begin);
            int u;
            while ((u = fs.ReadByte()) != -1)
            {
                if (u == letterByte) u = '*';
                Console.Write((char)u + "  ");

            }
            Console.WriteLine();
            fs.Flush(); // Освободить буфер
            fs.Close(); // Закрыть поток и файл
            fs = null;  // Обнулить ссылку на поток
            Console.ReadKey();
        }
    }
}
