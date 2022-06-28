using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    public class DegreeConverterTests
    {
        [Test]
        public void DegreeConverter_CelsiusTofahrenheit_return32()
        {
            double result = DegreeConverter.ToFahrenheit(0);
            Assert.That(result, Is.EqualTo(32));
                        
        }
        [Test]
        public void DegreeConverter_fahrenheitToCelsius_return5()
        {
            double result = DegreeConverter.ToCelsius(1);
            Assert.That(result, Is.EqualTo(0));
        }
            [Test]
        public void ToFahenheit_InvalidFormat_ThrowsInvalidFormatException()
        {
            TestDelegate action = () => DegreeConverter.ToFahrenheit(600);
            Assert.Throws<FormatException>(action);
        }

        [Test]
        public void DegreeConverterToCelsius_InvalidFormat_ThrowsInvalidFormatException()
        {
            TestDelegate action = () => DegreeConverter.ToCelsius(600);
            Assert.Throws<FormatException>(action);
        }
    }
}
