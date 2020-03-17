using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.IO;

namespace task_06
{
    [DataContract]
    public class Student
    {
        [DataMember]
        string lastName;
        [DataMember]
        int year, algMark, prMark, engMark;
        public Student() { }

        public Student(string lastName, int year, int algMark, int prMark, int engMark)
        {
            this.lastName = lastName;
            this.year = year;
            this.algMark = algMark;
            this.prMark = prMark;
            this.engMark = engMark;
        }

        public int AlgMark { get => algMark; set => algMark = value; }
        public int PrMark { get => prMark; set => prMark = value; }
        public int EngMark { get => engMark; set => engMark = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Year { get => year; set => year = value; }
    }
    class Program
    {
        public static string StudentInfoToCSV(Student student)
        {
            return $"{student.LastName};{student.Year};{student.AlgMark};{student.PrMark};{student.EngMark}";
        }
        static void Main(string[] args)
        {
            /*List<Student> students = new List<Student>
            {
                new Student("Петров", 1, 8, 6, 9),
                new Student("Иванов", 1, 4, 2, 5),
                new Student("Сидоров", 1, 5, 6, 7)
            };*/

            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<Student>));
            List<Student> dStudents = new List<Student>();
            /*FileStream fs = new FileStream("Students.json", FileMode.Create);

            ser.WriteObject(fs, students);
            fs.Close(); */

            Console.WriteLine($"фамилия\t курс\t алгебра\t английский\t программирование");

            FileStream dfs = new FileStream("Students.json", FileMode.Open);
            try
            {
                double alg_a = 0, eng_a = 0, pr_a = 0;
                int scount = 0;
                dStudents = (List<Student>)ser.ReadObject(dfs);
                foreach (var student in dStudents)
                {
                    Console.WriteLine($"{student.LastName}\t {student.Year}" +
                        $"\t {student.AlgMark}\t\t {student.EngMark}\t\t {student.PrMark}");
                    alg_a += student.AlgMark;
                    eng_a += student.EngMark;
                    pr_a += student.PrMark;
                    scount++;
                }
                Console.WriteLine($"Средний балл\t {(alg_a / scount):f2}\t\t {(eng_a / scount):f2}\t\t {(pr_a / scount):f2}");
            }
            catch (SerializationException)
            {
                dfs.Close();
            }

                Console.WriteLine("Нажмите C для сохранения в CSV; J - для сохранение в json; любую другую клавишу для выхода.");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.C:
                        {
                            try
                            {
                                StreamWriter csvSW = new StreamWriter("Students.csv", false, Encoding.UTF8);
                                foreach (var student in dStudents)
                                {
                                    csvSW.WriteLine(StudentInfoToCSV(student));
                                }
                                csvSW.Close();
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        break;

                    case ConsoleKey.J:
                        {
                            try
                            {
                                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Student>));
                                FileStream xmlFS = new FileStream("Students.xml", FileMode.Create);
                                xmlSerializer.Serialize(xmlFS, dStudents);
                                xmlFS.Close();
                            }
                            catch (Exception ex) { Console.WriteLine(ex.Message); }
                        }
                        break;
                }
        }
    }
}
