using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace task_02_json
{
    [Serializable]
    [KnownType(typeof(Professor))]
   // [DataContract]
    public class Human
    {
       // [DataMember]
        public string Name { get; set; }
        public Human() { }
        public Human(string name)
        {
            this.Name = name;
        }
    }
    [Serializable]
    //[DataContract]
    public class Professor : Human
    {
        public Professor() { }
        public Professor(string name) : base(name) { }
    }

   // [DataContract]
   [Serializable]
    public class Dept
    {
       // [DataMember]
        public string DeptName { get; set; }
      //  [DataMember]
        public List<Human> staff;
        public Dept() { }
        public Dept(string name, Human[] staffList)
        {
            this.DeptName = name;
            staff = new List<Human>(staffList);
        }
    }

    [Serializable]
   // [DataContract]
    public class University
    {
        public University() { }
     //   [DataMember]
        public string UniversityName { get; set; }
     //   [DataMember]
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

            DataContractJsonSerializer formater = new DataContractJsonSerializer(typeof(University));
            FileStream hse_fs = new FileStream("jsonSer.json", FileMode.Create);
            formater.WriteObject(hse_fs, HSE);
            hse_fs.Close();

            hse_fs = new FileStream("jsonSer.json", FileMode.Open);
            while (true)
                try
                {
                    DataContractJsonSerializer deserializer = new DataContractJsonSerializer(typeof(University));
                    University HSEdeserial = (University)deserializer.ReadObject(hse_fs);
                    Console.WriteLine("json - " + HSEdeserial.UniversityName);
                    foreach (Dept d in HSEdeserial.Departments)
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
