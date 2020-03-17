﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Text;

namespace task_02
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor() { }
        public Professor(string name) : base(name) { }
    }

    [Serializable]
    public class Dept
    {
        public string DeptName { get; set; }

        List<Human> staff;
        public List<Human> Staff { get { return staff; } }
        public Dept() { }
        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }

    [Serializable]
    public class University
    {
        public University() { }
        public string UniversityName { get; set; }
        public List<Dept> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            University HSE = new University
            {
                UniversityName = "NRU HSE"
            };

            Human[] deptStaff = { new Professor("Ivanov"),
                                  new Professor("Petrov")
                                };

            Dept SE = new Dept("SE", deptStaff);

            HSE.Departments = new List<Dept>
            {
                SE
            };

            BinaryFormatter binformatter = new BinaryFormatter();

            // Сериализация
            using (Stream file = new FileStream("BinSer.dat", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                binformatter.Serialize(file, HSE);
            }

            // Десериализация
            University HSEdeserial;

            using (Stream file = File.OpenRead("BinSer.dat"))
            {
                HSEdeserial = (University)binformatter.Deserialize(file);
                Console.WriteLine("Binary - " + HSEdeserial.UniversityName);
            }

            foreach (Dept d in HSEdeserial.Departments)
                foreach (Human h in d.Staff)
                {
                    if (h is Professor)
                        Console.WriteLine(d.DeptName + " prof.: " + h.Name);
                }

            Console.ReadKey();
        }
    }
}
