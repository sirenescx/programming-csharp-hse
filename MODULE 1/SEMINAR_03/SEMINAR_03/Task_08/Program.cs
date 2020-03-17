using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_08
{
    class Program
    {
        static int natural_seq()
        {
            int x = 1;
            while (x * (x + 1) % 111 != 0) x++;
            int s = x * (x + 1) / 2;
            Console.WriteLine($"{s}");
            Console.WriteLine($"Количество членов ряда = {x}");
            Console.WriteLine($"Условное изображение соответствующей суммы: 1 + 2 + 3 + ... + {x - 2} + {x - 1} + {x}");
            return 0;
        }

        static void Main()
        {
            natural_seq();
            Console.ReadLine();
        }
    }
}
