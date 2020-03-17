using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public delegate double delegateConvertTemperature(double x);

    public class TemperatureConverterImp
    {
        // Part 2 - Will be attached to a delegate later in the code
        public double ConvertToFahrenheit(double celsius)
        {
            return (celsius * 9.0 / 5.0) + 32.0;
        }

        public double ConvertToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32.0) * 5.0 / 9.0;
        }
    }




}
