using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_01
{
    public interface IWorker
    {
       int Salary { get; }
    }

    public class Worker : IWorker
    {
        int moneyPerHour;
        int workingHours;
        int salary;

        public Worker(int moneyPerHour, int workingHours)
        {
            this.moneyPerHour = moneyPerHour;
            this.workingHours = workingHours;
        }

        public int MoneyPerHour { get => moneyPerHour; set => moneyPerHour = value; }
        public int WorkingHours { get => workingHours; set { workingHours = value; } }

        public int Salary
        {
            get
            {
                if (workingHours <= 40)
                    salary = moneyPerHour * workingHours * 4;
                if (workingHours > 40)
                    salary = (moneyPerHour * 40 + 2 * moneyPerHour * (workingHours - 40)) * 4;
                return salary;
            }
        }
        public override string ToString() => $"Worker. Money per Hour = {moneyPerHour}. Working Hours = {workingHours}. Salary = {Salary}";

    }

    public class Manager : IWorker
    {
        int averageSalary;
        int amountOfWorkers;

        public Manager(int averageSalary, int amountOfWorkers)
        {
            this.averageSalary = averageSalary;
            this.amountOfWorkers = amountOfWorkers;
        }

        public int AverageSalary { get => averageSalary; set => averageSalary = value; }
        public int AmountOfWorkers { get => amountOfWorkers; set => amountOfWorkers = value; }

        public int Salary { get => averageSalary + 2 * amountOfWorkers / 100; }
        public override string ToString() => $"Manager. Average Salary = {averageSalary}. Amount of Workers = {amountOfWorkers}. Salary = {Salary}";

    }
    class Program
    {
        public void PrintInfo<T>(T[] ar, int MaxValue) where T : IWorker
        {
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i].Salary > MaxValue)
                    Console.WriteLine(ar[i]);
            }
        } 

        static Random rnd = new Random();
        static void Main(string[] args)
        {
            int maxValue;

            Worker[] workers = new Worker[10];
            for (int i = 0; i < workers.Length; i++)
            {
                workers[i] = new Worker(rnd.Next(100, 401), rnd.Next(20, 51));
            }

            Manager[] managers = new Manager[10];
            for (int i = 0; i < managers.Length; i++)
            {
                managers[i] = new Manager(rnd.Next(10000, 1000001), rnd.Next(5, 51));
            }

            foreach (var worker in workers)
            {
                Console.WriteLine(worker);
            }

            foreach (var manager in managers)
            {
                Console.WriteLine(manager);
            }

           // Console.WriteLine("Enter maximum salary value: ");
           // int.TryParse(Console.ReadLine(), out maxValue);
            Console.ReadKey();
        }
    }
}
