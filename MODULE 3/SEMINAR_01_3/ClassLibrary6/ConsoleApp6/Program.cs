using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary6;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Robot rob = new Robot(); // конкретный робот
            Steps[] trace = { new Steps(rob.Backward), new Steps(rob.Backward), new Steps(rob.Left) }; // сообщить координаты

            Console.WriteLine("Start:" + rob.Position());
            for (int i = 0; i < trace.Length; i++)
            {
                Console.WriteLine("Method={0}, Target={1}",
                trace[i].Method, trace[i].Target);
                trace[i]();
            }
            Console.WriteLine(rob.Position()); // сообщить координаты

            Steps delR = new Steps(rob.Right); // направо
            Steps delL = new Steps(rob.Left); // налево
            Steps delF = new Steps(rob.Forward); // вперед
            Steps delB = new Steps(rob.Backward); // назад

            // шаги по диагоналям (многоадресные делегаты):
            Steps delRF = delR + delF;
            Steps delRB = delR + delB;
            Steps delLF = delL + delF;
            Steps delLB = delL + delB;

            delLB();
            Console.WriteLine(rob.Position()); // сообщить координаты
            delRB();
            Console.WriteLine(rob.Position()); // сообщить координаты

            string s = Console.ReadLine();
            char[] controls = new char[s.Length];
            for (int i = 0; i < controls.Length; i++)
            {
                controls[i] = s[i];
            }

            Steps track = null;

            for (int i = 0; i < controls.Length; i++)
            {
                if (controls[i] == 'R') track += new Steps(rob.Right);
                if (controls[i] == 'L') track += new Steps(rob.Left);
                if (controls[i] == 'F') track += new Steps(rob.Forward);
                if (controls[i] == 'B') track += new Steps(rob.Backward);
            }

            if (track != null) track();

            Console.WriteLine(rob.Position());

            Console.WriteLine("Для завершения нажмите любую клавишу.");
            Console.ReadKey();
        }
    }
}
