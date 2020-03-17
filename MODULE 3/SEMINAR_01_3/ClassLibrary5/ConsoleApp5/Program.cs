using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary5;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            //  double tCtF = 140;
            //  double tFtC = 10;
            double cT = double.Parse(Console.ReadLine());

            delegateConvertTemperature[] delegates = new delegateConvertTemperature[2];
            delegates[0] = temperature =>
                    new TemperatureConverterImp().CelsiusToFarengheit(temperature);
            delegates[0] += temperature => StaticTempConverters.CelsiusToKelvin(temperature);
            delegates[0] += temperature => StaticTempConverters.CelsiusToRankin(temperature);
            delegates[0] += temperature => StaticTempConverters.CelsiusToReaumur(temperature);
            delegates[1] = temperature =>
                    new TemperatureConverterImp().FarengheitToCelsius(temperature);

            //  delegateConvertTemperature CtF = temperature =>
            //          new TemperatureConverterImp().CelsiusToFarengheit(temperature);
            //  delegateConvertTemperature FtC = temperature =>
            //          new TemperatureConverterImp().FarengheitToCelsius(temperature);

            //  Console.WriteLine(CtF(tCtF));
            //  Console.WriteLine(FtC(tFtC));

            Console.ReadKey();

        }
    }
}
