using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [TestCase(5,"Buzz")]
        [TestCase(15, "FizzBuzz")]
        [TestCase(3, "Fizz")]
        [TestCase(11, "")]
        public void FizzBuzz_SetNumbers_ReturnCorrectValue(int number, string answer)
        {
            string ans = FizzBuzz.Ask(number);
            Assert.That(ans, Is.EqualTo(answer));
        }

    }
}
