using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    public delegate void Steps();
    public class Robot
    {
        // класс для представления робота
        int x, y; // положение робота на плоскости
        public void Right() { x++; } // направо
        public void Left() { x--; } // налево
        public void Forward() { y++; } // вперед
        public void Backward() { y--; } // назад
        public string Position()
        { // сообщить координаты
            return $"The Robot position: x={x}, y={y}";
        }
    }
}
