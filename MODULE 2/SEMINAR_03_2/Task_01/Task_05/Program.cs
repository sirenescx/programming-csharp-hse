using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_05
{
    class Program
    {
        static Random rand = new Random();
        const string alphabet = "abcdefghijklmnopqrstuvwxyz";

        public static string FileName(int length)
        {
            StringBuilder sb = new StringBuilder(length - 1);
            int Position = 0;
            for (int i = 0; i < length; i++)
            {
                Position = rand.Next(0, alphabet.Length);
                sb.Append(alphabet[Position]);
            }
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            int n = rand.Next(5, 16);
            VideoFile videoFile = new VideoFile("sample", 120, 720);
            VideoFile[] arr = new VideoFile[n];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new VideoFile(FileName(rand.Next(2, 10)), rand.Next(60, 361), rand.Next(100, 1001));
                if (arr[i].Size > videoFile.Size) Console.WriteLine(arr[i].ToString()); 
            }
        }
    }
}
