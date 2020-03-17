using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    class Program
    {
        static bool Function(bool p, bool q)
        {
            return !(p & q) & !(p | !q);
        }

        static void Main()
        {
            bool p = true, q, res;
            Console.WriteLine("Таблица истинности !(p & q) & !(p | !q)");
            Console.WriteLine(" p \t q \t F");
            do
            {
                q = true;
                do
                {
                    res = Function(p, q); // Вызов Function()
                    Console.WriteLine("{0}\t{1}\t{2}", Convert.ToInt32(p), Convert.ToInt32(q), Convert.ToInt32(res));
                    q = !q;
                } while (!q);
                p = !p;
            } while (!p);
            Console.WriteLine("Для выхода нажмите ENTER");
            Console.ReadLine();
        }
    }
}
