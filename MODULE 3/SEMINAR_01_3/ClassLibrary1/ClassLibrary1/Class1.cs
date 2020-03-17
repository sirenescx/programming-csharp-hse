using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public delegate int[] Row(int num); // делегат-тип 
    public delegate void Print(int[] ar); // делегат-тип

    public class Example
    {
        static public int[] GetDigits(int num)
        {
            int arLen = (int)Math.Log10(num) + 1;
            int[] res = new int[arLen];
            for (int i = arLen - 1; i >= 0; i--)
            {
                res[i] = num % 10;
                num /= 10;
            }
            return res;
        }
        static public void Display(int[] ar)
        {
            for (int i = 0; i < ar.Length; i++)
                Console.Write("{0}\t", ar[i]);
            Console.WriteLine();
        }

        static public int[] fib(int n)
        {
            int[] result = new int[n];
            if (n == 1) result[n - 1] = 0;
            if (n == 2)
            {
                result[n - 2] = 0;
                result[n - 1] = 1;
            }
            if (n >= 3)
            {
                result[0] = 0;
                result[1] = 1;
                for (int i = 2; i < result.Length; i++)
                    result[i] = result[i - 1] + result[i - 2];
            }
            return result;
        }

        static public void printSum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];
            Console.WriteLine(sum);
        }
    }

}
