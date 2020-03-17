using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    class Program {
        public static string Report04(uint code, out string report)
        {
            report = code <= '9' && code >= '0' ? "Это цифра: " + (char)code
            : code <= 'Я' && code >= 'А' ? "Это прописная буква: " + (char)code
            : code <= 'я' && code >= 'а' ? "Это строчная буква: " + (char)code
            : "Неизвестный код!";
            return report;
        }

        public static void Main()
        {
            uint code;
            string str; // Строка для приёма данных
            string report; // Строка с заключением о коде
            uint код_А = (uint)'А', // Числовое значение кода буквы А
                 код_а = (uint)'а',
                 код_я = (uint)'я',
                 код_Я = (uint)'Я',
                 код_0 = (uint)'0'; // Числовое значение кода цифры 0
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Коды граничных символов");
                Console.WriteLine("Код А = " + код_А + "; Код Я = " + код_Я +
                                "; Код а = " + код_а + "; Код я = " + код_я +
                                "; Код нуля = " + код_0);
                Console.Write("Введите значение code: ");
                str = Console.ReadLine();
                uint.TryParse(str, out code);
                Report04(code, out report);
                Console.WriteLine(report);
                Console.WriteLine("Для выхода нажмите ESC");
            }
        }
    }
}
