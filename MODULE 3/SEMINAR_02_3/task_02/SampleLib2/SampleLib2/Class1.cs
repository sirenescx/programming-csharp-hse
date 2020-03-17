using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLib2
{
    public delegate void CarEngineHandler(string msgForCaller);

    public class Car
    {
        // Информация о внутреннем состоянии
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; }
        public string PetName { get; set; }
        // Машина работоспособна?
        private bool carIsDead;
        // Конструкторы
        public Car() { MaxSpeed = 100; }
        public Car(string name, int maxSp, int currSp)
        {
            CurrentSpeed = currSp;
            MaxSpeed = maxSp;
            PetName = name;
        }

        private CarEngineHandler listOfHandlers;

        public void RegisterWithCarEngine(CarEngineHandler methodToCall)
        {
            listOfHandlers = methodToCall;
        }

        public void Accelerate(int delta)
        {
            // Если машина сломана, отправляем оповещение.
            if (carIsDead)
            {
                listOfHandlers?.Invoke("К сожалению, машина сломана :( ...");
            }
            else
            {
                CurrentSpeed += delta;
                // Машина почти сломана?
                if (10 == (MaxSpeed - CurrentSpeed) && listOfHandlers != null)
                {
                    listOfHandlers("Предупреждение! Будь осторожнее");
                }

                if (CurrentSpeed >= MaxSpeed)
                    carIsDead = true;
                else
                    Console.WriteLine($"Скорость = {CurrentSpeed}");
            }
        }
    }
}
