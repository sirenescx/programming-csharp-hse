using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_04
{
    class Stack<ItemType>
    {
        static int stackSize = 100;
        private ItemType[] items = new ItemType[stackSize];
        private int index;
        public void Push(ItemType data)
        {
            if (index == stackSize)
                throw new ApplicationException("Stack is overflowed.");
            items[index++] = data;
        }

        public ItemType Pop()
        {
            if (index == 0)
                throw new ApplicationException("Stack is empty.");
            return items[--index];
        }
    }

    public class Point
    {
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }
        public double Y { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Stack<char> charStack = new Stack<char>();
                charStack.Push('A');
                Console.WriteLine("charStack.Pop() = " + charStack.Pop());
                Stack<double> doubleStack = new Stack<double>();
                doubleStack.Push(3.14159);
                double x = doubleStack.Pop();
                Console.WriteLine("x = " + x);
                // charStack.Push(2.7171); - ошибка компиляции
                Stack<Point> pointStack = new Stack<Point>();
                pointStack.Push(new Point(1, 2));
                Point p = pointStack.Pop();
                Console.WriteLine("p.X = {0}, p.Y = {1}", p.X, p.Y);
            }
            while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}
