using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Part 4 - Instantiate the main object
            TemperatureConverterImp obj = new TemperatureConverterImp();
            //  Part 5 - Intantiate delegate #1
            delegateConvertTemperature delConvertToFahrenheit =
                              new delegateConvertTemperature(obj.ConvertToFahrenheit);
            //  Part 6 - Intantiate delegate #2
            delegateConvertTemperature delConvertToCelsius =
                                 new delegateConvertTemperature(obj.ConvertToCelsius);

            //  Part 7 - delegate #1
            double celsius = 0.0;
            double fahrenheit = delConvertToFahrenheit(celsius);
            string msg1 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                                         celsius, fahrenheit);
            Console.WriteLine(msg1);

            //  Part 8 - delegate #2
            fahrenheit = 212.0;
            celsius = delConvertToCelsius(fahrenheit);
            string msg2 = string.Format("Celsius = {0}, Fahrenheit = {1}",
                                                         celsius, fahrenheit);
            Console.WriteLine(msg2);

        }
    }
}
