using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    class Program
    {
        static Random rand = new Random();
        static void Main(string[] args)
        {
            /*SalesEmployee employee1 = new SalesEmployee("Alice",
              1000, 500);
            Employee employee2 = new Employee("Bob", 1200);

            Console.WriteLine("Employee4 " + employee1.name +
                      " earned: " + employee1.CalculatePay());
            Console.WriteLine("Employee4 " + employee2.name +
                      " earned: " + employee2.CalculatePay()); */

            Employee[] employees = new Employee[rand.Next(5, 15)];
            for (int i = 0; i < employees.Length; i++)
            {
                if (rand.Next(0, 3) % 2 == 0) employees[i] = new SalesEmployee($"Employee{i}", rand.Next(100, 3000), rand.Next(1, 100));
                else employees[i] = new PartTimeEmployee($"PartTimeEmployee{i}", rand.Next(100, 3000), rand.Next(1, 30));
                Console.WriteLine(employees[i].name +
                      " earned: " + employees[i].CalculatePay());
            }
        }
    }
}
