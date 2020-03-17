using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_02_class_library
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
        public struct Person
    {
        public Person(string name, string surname, int age) : this()
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " " + Surname + " " + Age;
        }
    }

    public class ElectronicQueue<T> where T: struct
    {
        public Queue<Person> electronicQueue = new Queue<Person>();
        public void AddToElectronicQueue(Person p)
        {
            electronicQueue.Enqueue(p);
        }

        public string CallFromElectronicQueue()
        {
            string output = "";
            if (electronicQueue.list.Count != 0)
            // if (electronicQueue.Count != 0)
            {

                //Person tmp = electronicQueue.Peek();
                Person tmp = electronicQueue.list.Last();
                output = tmp.ToString();
                return output;

            }
            return null;

        }

        public void DeleteFromElectronicQueue()
        {
            electronicQueue.Dequeue();
        }
    }
}
