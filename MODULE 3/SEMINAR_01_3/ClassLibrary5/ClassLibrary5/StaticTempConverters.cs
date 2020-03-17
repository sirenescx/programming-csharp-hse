using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public static class StaticTempConverters
    {
        public static double CelsiusToKelvin(double temperature)
        {
            return temperature + 273.15;
        }

        public static double KelvinToCelsius(double temperature)
        {
            return temperature - 273.15;
        }

        public static double CelsiusToRankin(double temperature)
        {
            return (temperature + 273.15) * 9.0 / 5;
        }

        public static double RankinToCelsius(double temperature)
        {
            return (temperature - 491.67) * 5.0 / 9;
        }

        public static double CelsiusToReaumur(double temperature)
        {
            return temperature * 4.0 / 5;
        }

        public static double ReaumurToCelsius(double temperature)
        {
            return temperature * 5.0 / 4;
        }
    }
}
