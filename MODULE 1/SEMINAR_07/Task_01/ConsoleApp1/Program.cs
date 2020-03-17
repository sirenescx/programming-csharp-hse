using System; // Для доступа к классу Console
using System.IO;
using System.Linq;

// Для работы с файлами и директориями

namespace Directories
{
    class Program
    {
        static void DirectoryOverview(string path)
        {
            //получаем имена всех директорий, вложенных в данную директорию по пути path
            var directories = Directory.GetDirectories(path);

            //проходимся по всем директориям
            for (int i = 0; i < directories.Length; i++)
            {
                var directory = directories[i];
                //создаем объект типа directoryInfo, хранящий информацию о директории по пути
                var directoryInfo = new DirectoryInfo(directory);

                if (directoryInfo.GetDirectories().Any() ||
                    directoryInfo.GetFiles().Any())

                {
                    Console.WriteLine("EMPTY");
                }

                Console.WriteLine($"{directory}\n" +
                                  //список всех атрибутов директории
                                  $"attributes: {directoryInfo.Attributes}; " +
                                  //время создания
                                  $"creation time: {directoryInfo.CreationTime} " +
                                  //последнее обновление
                                  $"last update:{directoryInfo.LastWriteTime}\n");


               if (!directoryInfo.EnumerateFiles().Any() ||
                !directoryInfo.EnumerateDirectories().Any()) 

                //рекурсивно выполняем метод для всех вложенных директорий
                DirectoryOverview(directory);
            }
            //выводим информацию о соответствующих свойствах директории
        }

        static void Main(string[] args)
        {
            // Блок try-catch при работе с файлами обязателен!
            try
            {
                DirectoryOverview(@"..\..\..\");
            }
            catch
            {

            }

            Console.WriteLine("Нажмите любую клавишу, чтобы выйти...");
            Console.ReadLine();
        }
    }

}