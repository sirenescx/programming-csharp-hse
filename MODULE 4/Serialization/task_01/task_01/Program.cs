using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace task_01
{
    [Serializable]
    public class Student
    {
        public Student() { }

        public Student(string name, int year)
        {
            this.name = name;
            this.year = year;
        }

        public string name;
        public int year;
    }

    [Serializable]
    public class Group
    {
        public Group() { }
        public string ident;   // group's identifier
        public Student[] list;  // students' list
        public Group(string id, Student[] list)
        {
            ident = id;
            this.list = list;
        }
        public new string ToString()
        {
            string temp = ident + ": ";
            foreach (Student st in list)
                temp += st.name + "-" + st.year + "  ";
            return temp;

        }
        class Program
        {
            static void Main(string[] args)
            {
                Student[] list171 = {new Student("Иванов", 1),
        new Student("Петров", 1),new Student("Сидоров",1)};
                Group gr171 = new Group("ПИ-171", list171);
                Student[] list271 = {new Student("Яколев", 2),
        new Student("Юрьевa", 2),new Student("Энатов",2)};
                Group gr271 = new Group("ПИ-271", list271);

                Group[] groups = new Group[] { gr171, gr271 };

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Group[]));
                FileStream group_fs = new FileStream("group.ser", FileMode.Create);
                xmlSerializer.Serialize(group_fs, groups);
                group_fs.Close();

                group_fs = new FileStream("group.ser", FileMode.Open);
                Console.WriteLine("Выполнена запись в файл group.ser");
                while (true)
                    try
                    {
                        Group[] gr = (Group[])xmlSerializer.Deserialize(group_fs);
                        foreach (var item in gr)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    catch (Exception)
                    { // - в конце файла
                        group_fs.Close();
                        break;
                    }
                Console.ReadKey();
            }
        }
    }
}
