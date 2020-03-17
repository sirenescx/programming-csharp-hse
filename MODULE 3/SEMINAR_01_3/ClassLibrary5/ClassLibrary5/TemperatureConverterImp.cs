using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary5
{
    public delegate double delegateConvertTemperature(double temperature);
    public class TemperatureConverterImp
    {
        public double CelsiusToFarengheit(double Temperature)
        {
            return 5.0 / 9 * (Temperature - 32);
            
        }
        
        public double FarengheitToCelsius(double Temperature)
        {
            return 9.0 / 5 * (Temperature + 32);
        }
    }
}
