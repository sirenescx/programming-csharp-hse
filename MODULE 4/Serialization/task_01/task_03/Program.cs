using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using System.Text;

namespace task_03
{
    delegate void q_delegate(Quadratic qe);
    delegate void q_list_delegate(List<Quadratic> quadratics);

    [Serializable]
    public class Quadratic
    {
        public double a, b, c;

        public Quadratic() { }
        public Quadratic(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            if (a == 0) throw new ArithmeticException();
        }

        public double Discriminant { get => Math.Pow(b, 2) - 4 * a * c; }

        public double X1 { get => (-b + Math.Sqrt(Discriminant)) / (2 * a); }
        public double X2 { get => (-b - Math.Sqrt(Discriminant)) / (2 * a); }
    }

    class Processing
    {
        static Random gen = new Random();

        static public void WriteFile(string nameFile, int numb)
        {
            using (FileStream streamOut = new FileStream(nameFile, FileMode.Create))
            {
                BinaryFormatter formatOut = new BinaryFormatter();
                for (int j = 0; j < numb; j++)
                {
                    try
                    {   // При А==0 - уравнение вырождается в линейное
                        Quadratic q = new Quadratic(gen.Next(-10, 11), gen.Next(-10, 11), gen.Next(-10, 11));
                        formatOut.Serialize(streamOut, q);
                    }
                    catch (ArithmeticException)
                    {  // Заменить вырожденное уравнение:
                        j--;
                        continue;
                    }
                }
            }
        }   // WriteFile() 

        static public void WriteXMLFile(string nameFile, int numb)
        {
            List<Quadratic> quadratics = new List<Quadratic>();
            for (int j = 0; j < numb; j++)
            {
                try
                {   // При А==0 - уравнение вырождается в линейное
                    Quadratic q = new Quadratic(gen.Next(-10, 11), gen.Next(-10, 11), gen.Next(-10, 11));
                    quadratics.Add(q);
                }
                catch (ArithmeticException)
                {  // Заменить вырожденное уравнение:
                    j--;
                    continue;
                }
            }

            using (FileStream streamOutXML = new FileStream(nameFile, FileMode.Create))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Quadratic>));
                xmlSerializer.Serialize(streamOutXML, quadratics);
                /*   for (int j = 0; j < numb; j++)
                   {
                       try
                       {   // При А==0 - уравнение вырождается в линейное
                           Quadratic q = new Quadratic(gen.Next(-10, 11), gen.Next(-10, 11), gen.Next(-10, 11));
                           xmlSerializer.Serialize(streamOutXML, q);
                       }
                       catch (ArithmeticException)
                       {  // Заменить вырожденное уравнение:
                           j--;
                           continue;
                       }
                   } */
                streamOutXML.Close();
            }
        }   // WriteFileXML()

        public static void Process(string fileName, q_delegate q_del)
        {
            using (FileStream streamIn = new FileStream(fileName, FileMode.Open))
            {
                BinaryFormatter formatIn = new BinaryFormatter();
                Quadratic eq;
                while (true) // читать до конца файла - там исключение 
                    try
                    {
                        eq = (Quadratic)formatIn.Deserialize(streamIn);
                        q_del(eq);
                    }
                    catch (SerializationException)
                    {
                        streamIn.Close();
                        break;
                    }
            }
        }   // Process() 

        public static void ProcessXML(string fileName, q_list_delegate q_list_del)
        {
            List<Quadratic> quadratics = new List<Quadratic>();
            using (FileStream streamInXML = new FileStream(fileName, FileMode.Open))
            {
                if (streamInXML.Position > 0)
                {
                    streamInXML.Position = 0;
                }
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Quadratic>));
                //Quadratic eq;
                try
                {
                    quadratics = (List<Quadratic>)xmlSerializer.Deserialize(streamInXML);
                    q_list_del(quadratics);
                    // eq = (Quadratic)xmlSerializer.Deserialize(streamInXML);
                    // q_del(eq);
                }
                catch (SerializationException)
                {
                    streamInXML.Close();

                }
            }
        }   // ProcessXML() 

        public static void SolutionReal(Quadratic eq)
        {
            if (eq.Discriminant < 0) return;
            Console.WriteLine(eq.ToString() + "  дискриминант = " + eq.Discriminant);
            Console.WriteLine("\tКорни: Х1={0,3:g3}  \tX2={1,3:g3}", eq.X1, eq.X2);
        }   // SolutionReal()

        public static void SolutionRealXML(List<Quadratic> quadratics)
        {
            foreach (var eq in quadratics)
            {
                if (eq.Discriminant < 0) return;
                Console.WriteLine(eq.ToString() + "  дискриминант = " + eq.Discriminant);
                Console.WriteLine("\tКорни: Х1={0,3:g3}  \tX2={1,3:g3}", eq.X1, eq.X2);
            }
        }   // SolutionRealXML()

        /// <summary>
        /// Метод выводит на экран сведения об уравнении:
        /// </summary>
        /// <param name="eq"></param>
        public static void PrintEq(Quadratic eq)
        {
            Console.WriteLine(eq.ToString() + "  дискриминант = " + (eq.Discriminant).ToString("g3"));
        }

        public static void PrintEqXML(List<Quadratic> quadratics)
        {
            foreach (var eq in quadratics)
            {
                Console.WriteLine(eq.ToString() + "  дискриминант = " + (eq.Discriminant).ToString("g3"));
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Processing.WriteFile("equation.ser", 8);
            Processing.WriteXMLFile("equationXML.ser", 8);
            Console.WriteLine("Выполнена запись в режиме сериализации.");
            Console.WriteLine("Для вывода на экран нажмите любую клавишу.");
            Console.ReadKey(true);
            Console.WriteLine("В файле сведения о следующих уравнениях: ");
            // Обращение с использованием делегата:
            // Processing.Process("equation.ser", new q_delegate(Processing.PrintEq));
            Processing.ProcessXML("equationXML.ser", new q_list_delegate(Processing.PrintEqXML));
            Console.WriteLine("Для решения уравнений нажмите любую клавишу.");
            Console.ReadKey(true);
            Console.WriteLine("\nРешения уравнений с вещественными корнями: ");
            // Processing.Process("equation.ser", new q_delegate(Processing.SolutionReal));
            Processing.ProcessXML("equationXML.ser", new q_list_delegate(Processing.SolutionRealXML));
            Console.WriteLine("Для завершения работы нажмите ENTER.");
            Console.ReadLine();
        }
    }
}
