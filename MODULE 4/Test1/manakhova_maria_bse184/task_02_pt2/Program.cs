using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task_02_pt2
{
    class Program
    {
        // Можно было бы еще запоминать элементы в два списка и в конце записывать их в файлы.
        static void Main(string[] args)
        {
          //  List<int> primeList = new List<int>();
          //  List<int> compositeList = new List<int>();

            do
            {
                if (File.Exists("../../../prime.txt"))
                    File.WriteAllText("../../../prime.txt", string.Empty);

                if (File.Exists("../../../composite.txt"))
                    File.WriteAllText("../../../composite.txt", string.Empty);

                try
                {
                    using (StreamReader sr = new StreamReader("../../../input.txt"))
                    {
                        int x;
                        while (!sr.EndOfStream)
                        {
                            x = int.Parse(sr.ReadLine());
                            int count = 0;
                            for (int i = 2; i < x; i++)
                            {
                                if (x % i == 0) count++;
                            }
                            if (count == 0)
                            {
                                using (StreamWriter sw = new StreamWriter("../../../prime.txt", true))
                                {
                                    sw.WriteLine(x);
                                }
                                // primeList.Add(x);
                            }
                            else
                            {
                                using (StreamWriter sw = new StreamWriter("../../../composite.txt", true))
                                {
                                    sw.WriteLine(x);
                                }
                                // compositeList.Add(x);
                            }
                        }
                    }
                }
                catch (System.IO.FileNotFoundException) { Console.WriteLine("Файл input.txt не существует."); }
                catch (System.FormatException) { Console.WriteLine("Файл input.txt содержит неверные данные (файл должен состоять из целых чисел)."); }
                catch (System.UnauthorizedAccessException UAex) { Console.WriteLine(UAex.Message); }

                /* using (StreamWriter sw = new StreamWriter("../../../prime.txt"))
                 {
                     foreach (var item in primeList)
                     {
                         sw.WriteLine(item);
                     }
                 } */

                /* using (StreamWriter sw = new StreamWriter("../../../composite.txt"))
                   {
                       foreach (var item in compositeList)
                       {
                           sw.WriteLine(item);
                       }
                   } */

                Console.WriteLine("Для повтора нажмите любую клавишу, для выхода - Escape.");
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
