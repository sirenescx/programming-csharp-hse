using System.Collections.Generic;
using System;

namespace KL.SafeBoard
{
    public class Program
    {

        public static bool CheckString(string s) //, ref int indexFlag)
        {
            bool[] charSet = new bool[256];
            for (var i = 0; i < s.Length; i++)
            {
                var val = s[i];
                if (charSet[val])
                {
                    return false;
                }

                charSet[val] = true;
            }
            return true;
        }
        public static string ValidationResult(string s)
        {
           /* int index = default;
            bool result = CheckString(s, ref index);
            if (!result)
            {
                s = s.Remove(index, 1);
                result = CheckString(s, ref index);
            }
            else
            {
                result = CheckString(s, ref index);
                if (!result)
                {
                    return "YES";
                }
                return "NO";
            }
            if (!result)
            {
                return "YES";
            }
            return "NO";*/

           if (CheckString(s))
           {
               return "YES";
           }

           return "NO";
        }


        static void Main(string[] args)
        {
            Console.WriteLine(ValidationResult(Console.ReadLine()));
        }
    }
}
