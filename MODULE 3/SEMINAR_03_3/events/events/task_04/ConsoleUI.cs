using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04
{
    class ConsoleUI
    {
        public event Program.NewStringValue NewStringValueHappened;

        UIString s = new UIString(); // специальная строка
        public UIString S { get => s; set => s = value; }
        public void GetStringFromUI()
        {
            Console.WriteLine("Введите новое значение строки");
            string str = Console.ReadLine();
            NewStringValueHappened?.Invoke(str);
            RefreshUI();
        }
        public void CreateUI()
        {
            NewStringValueHappened += s.NewStringValueHappenedHandler;
            RefreshUI();
        }
        public void RefreshUI()
        {    
            Console.Clear();
            Console.WriteLine("Текст строки: " + s.Str);
        }
    }
}
