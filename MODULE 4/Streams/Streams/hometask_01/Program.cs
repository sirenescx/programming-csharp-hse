using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace hometask_01
{
    class Program
    {
        public static bool IdentCheck(string s)
        {
            if (s == "") return false;
            else
            if (s[0] >= '0' & s[0] <= '9') return false;
            else
            {
                foreach (var item in s.ToArray())
                {
                    if ((item >= 'A' & item <= 'Z') ||
                        (item >= 'a' & item <= 'z') ||
                        (item == '_'))
                        return true;
                    else return false;
                }
            }
            return true;
        }
        public static void SortByAlphabet(List<string> list)
        {
            list.Sort();
            using (StreamWriter sw = new StreamWriter(@"..\..\identifiers.txt"))
            {
                foreach (var item in list)
                {
                    sw.WriteLine(item);
                }
            }
        }

        static void Main(string[] args)
        {

            List<String> fileTextArray = new List<string>();
            List<String> identifiersArray = new List<string>();


            using (StreamReader sr = new StreamReader(@"..\..\Program.cs"))
            {
                string line;
                while (!sr.EndOfStream)
                {
                    line = sr.ReadLine();

                    if (!string.IsNullOrWhiteSpace(line))
                    {
                        var fileTextArrayString = line.Trim().Split(' ', '.', ',', '(', '<', '[', '/'); //nhhgiugyigy
                        foreach (var item in fileTextArrayString)
                        {
                            fileTextArray.Add((item.Trim(';', '>', ')', ']', '"')));
                        }
                    }
                }
            }

            foreach (var item in fileTextArray)
                if (IdentCheck(item)) identifiersArray.Add(item);

            SortByAlphabet(identifiersArray);

            Console.ReadLine();
        }
    }
}

