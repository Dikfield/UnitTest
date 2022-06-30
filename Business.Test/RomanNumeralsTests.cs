using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Tests
{
    [TestFixture]
    public class RomanNumeralsTests
    {
        [TestCase("II", 2)]
        [TestCase("V", 5)]
        [TestCase("IV", 4)]
        [TestCase("I", 1)]
        public void ArabicReturnTest_SendI_Return1(string roman, int expectedNumber)
        {
            Assert.AreEqual(expectedNumber, RomanNumerals.GetArabicNumerals(roman));
        }
    }
}
