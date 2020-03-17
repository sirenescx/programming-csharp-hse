using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace task_02_2
{
    [XmlInclude(typeof(Professor))]
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
        public List<Human> staff;
        //   List<Human> staff;
        //   public List<Human> Staff { get { return staff; } }
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

         //   Type[] extraTypes = new Type[] { typeof(Professor) };

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(University));
            FileStream hse_fs = new FileStream("XMLSer.ser", FileMode.Create);
            xmlSerializer.Serialize(hse_fs, HSE);
            hse_fs.Close();

            hse_fs = new FileStream("XMLSer.ser", FileMode.Open);
            Console.WriteLine("Выполнена запись в файл XMLSer.ser");
            while (true)
                try
                {
                    University HSEdeserialXML = (University)xmlSerializer.Deserialize(hse_fs);
                    Console.WriteLine("XML - " + HSEdeserialXML.UniversityName);
                    foreach (Dept d in HSEdeserialXML.Departments)
                        foreach (Human h in d.staff)
                        {
                            if (h is Professor)
                                Console.WriteLine(d.DeptName + " prof.: " + h.Name);
                        }
                }
                catch (Exception)
                {
                    hse_fs.Close();
                    break;
                }

            Console.ReadKey();
        }
    }
}
