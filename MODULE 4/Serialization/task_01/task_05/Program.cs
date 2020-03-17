using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace task_05
{
    [Serializable]
    public class Test
    {
        public string s;
        public int i;
        public readonly List<int> list;

        public Test() { }
        public Test(string s, int i, List<int> list)
        {
            this.s = s;
            this.i = i;
            this.list = list;
        }

        public override string ToString()
        {
            string sList = string.Empty;
            foreach (var num in list)
                sList += num.ToString() + " ";
            return $"s: {s}, i: {i}, list: {sList}";
        }

    }
    class Program
    {

        public static void change(int[] ar, int[] ar2)
        {
            ar2.CopyTo(ar, 0);
            //ar = ar2;
        }
        static void Main(string[] args)
        {
           /* try
            {
                Test test = new Test("test", 5, new List<int> { 1, 2, 3, 4 });
                XmlSerializer serializer = new XmlSerializer(typeof(Test));
                using (FileStream fs = new FileStream("test.xml", FileMode.Create))
                {
                    serializer.Serialize(fs, test);
                    test = null;
                    fs.Close();
                }

                using (FileStream dfs = new FileStream("test.xml", FileMode.Open))
                {
                    test = (Test)serializer.Deserialize(dfs);
                    dfs.Close();
                }

            }
            catch (Exception ex) { Console.WriteLine(ex.Message); } */
            int[] numbers = { 0, 0, 0, 0 };
            int[] numbers2 = { 1, 2, 3, 4 };


            IEnumerable<int> intNum = from n in numbers
                         where n < 2
                         select n;

            change(numbers, numbers2);

            foreach (var item in intNum)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
