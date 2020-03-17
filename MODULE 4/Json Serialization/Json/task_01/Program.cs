using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace task_01
{
    [Serializable]
    public class Student
    {
        public string lastName;
        public int year;
        public Student() { }
        public Student(string lastName, int year)
        {
            this.lastName = lastName;
            this.year = year;
        }
    }

    [Serializable]
    public class Group
    {

        public Student[] group;
        public string ident;
        public Group() { }

        public Group(Student[] group, string ident)
        {
            this.group = group;
            this.ident = ident;
        }

        public new string ToString()
        {
            string temp = ident + ": ";
            foreach (Student st in group)
                temp += st.lastName + "-" + st.year + "  ";
            return temp;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students181 = { new Student("Иванов", 1), new Student("Петров", 1) };
            Group group181 = new Group(students181, "181");
            Student[] students182 = { new Student("Яковлев", 1), new Student("Сидоров", 1), new Student("Юрьева", 1) };
            Group group182 = new Group(students182, "182");
            Group[] groups = { group181, group182};

            DataContractJsonSerializer formater = new DataContractJsonSerializer(typeof(Group[]));
            FileStream fs = new FileStream("groups.txt", FileMode.Create);
            formater.WriteObject(fs, groups);
            fs.Close();

            using (Stream s = File.OpenRead("groups.txt"))
            {
                Group[] desGroups = (Group[])formater.ReadObject(s);
                foreach (var group in desGroups)
                    Console.WriteLine(group.ToString());
            }
          /*  fs = new FileStream("groups.json", FileMode.Open);
            try
            {
                Group[] desGroups = (Group[])formater.ReadObject(fs);
                foreach (var group in desGroups)
                    Console.WriteLine(group.ToString());
            }
            catch (SerializationException)
            {
                fs.Close();
            } */

            Console.ReadKey();
        }
    }
}
