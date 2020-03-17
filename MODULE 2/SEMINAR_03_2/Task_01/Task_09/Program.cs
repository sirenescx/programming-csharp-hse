using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_09
{
    class Program
    {
        static Random rand = new Random();

        static void Swap(ref LinearEquation i, ref LinearEquation j)
        {
            LinearEquation temp;
            temp = i;
            i = j;
            j = temp;
        }
        static void SortArray(ref LinearEquation[] equations)
        {
            for (int i = 0; i < equations.Length - 1; i++)
            {
                for (int j = i + 1; j < equations.Length; j++)
                    if (equations[i].Solve() > equations[j].Solve()) Swap(ref equations[i], ref equations[j]); 
            }
        }
        static void Main(string[] args)
        {
            int n = 0;
            do
            {
                Console.Write("Please enter size of the array: ");
            } while (!int.TryParse(Console.ReadLine(), out n) || n < 0);

            LinearEquation[] linearEquations = new LinearEquation[n];

            for (int i = 0; i < linearEquations.Length; i++)
            {
                linearEquations[i] = new LinearEquation(rand.Next(-10, 11), rand.Next(-10, 11), rand.Next(-10, 11));
                Console.WriteLine(linearEquations[i].ToString());
            }

            SortArray(ref linearEquations);

            Console.WriteLine("");
            Console.WriteLine("Sorted Array: ");
            for (int i = 0; i < linearEquations.Length; i++)
                Console.WriteLine(linearEquations[i].ToString());
        }
    }
}
