using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_05
{
    public class Queue<T>
    {
        T First;
        T Last;
        const int Capacity = 100;
        public LinkedList<T> list = new LinkedList<T>();
        bool IsEmpty { get { return list.Count() >= 0 ? false : true; } }
        bool IsFull { get { return list.Count() == Capacity ? true : false; } }

        public void Enqueue(T value)
        {
            if (!IsFull)
            {
                list.AddFirst(value);
            }
        }

        public void Dequeue()
        {
            if (!IsEmpty)
            {
                list.RemoveLast();
            }
        }
    }
    class MyStack<T>
    {
        const int MaxStack = 10;
        T[] StackArray;
        int StackPointer = 0;
        public MyStack() { StackArray = new T[MaxStack]; }
        bool IsStackFull { get { return StackPointer >= MaxStack; } }
        bool IsStackEmpty { get { return StackPointer <= 0; } }
        public void Push(T x)
        {
            if (!IsStackFull)
                StackArray[StackPointer++] = x;
        }

        public T Pop(T x)
        {
            return (!IsStackEmpty) ? StackArray[--StackPointer] : StackArray[0];
        }

        /*   public void Print()
           {
               Array.Reverse(StackArray);
               foreach (var item in StackArray)
                   Console.WriteLine($" Value: {item}");
           } */

        public override string ToString()
        {
            string PrintInfo = "";
            Array.Reverse(StackArray);
            foreach (var item in StackArray)
                PrintInfo += $" Value: {item}\n";
                return PrintInfo;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var stackInt = new MyStack<int>();
                var stackString = new MyStack<string>();
                stackInt.Push(3); stackInt.Push(5); stackInt.Push(7);
                //stackInt.Print();
                Console.WriteLine(stackInt);
                stackString.Push("Generics are great!");
                stackString.Push("Hi there! ");
                //stackString.Print();
                Console.WriteLine(stackString);
            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }
    }
}
