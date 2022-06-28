using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    public static class DegreeConverter
    {
        public static double ToFahrenheit(double celsius)
        {
            if (celsius < - 273 || celsius > 273)
            {
                throw new FormatException("Port is not in a correct format.");
            }
            else
                return (celsius * 9 / 5) + 32;
        }
        public static double ToCelsius(double fahrenheit)
        {
            if (fahrenheit<-524 || fahrenheit > 524)
            {
                throw new FormatException("Port is not in a correct format.");
            }
            else
                return (32 * fahrenheit - 32) * 5 / 9;
        }
    }
}
