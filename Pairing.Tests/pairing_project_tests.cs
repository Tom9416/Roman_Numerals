using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Pairing_Project.Tests
{
    [TestFixture]
    public class ExampleTests
    {
        [TestCase(1 , "I")]
        [TestCase(2 , "II")]
        [TestCase(3 , "III")]
        [TestCase(4 , "IV")]
        [TestCase(5, "V")]
        [TestCase(10, "X")]
        [TestCase(50, "L")]
        [TestCase(100, "C")]
        [TestCase(200, "CC")]
        [TestCase(229, "CCXXIX")]
        [TestCase(500, "D")]
        [TestCase(666, "DCLXVI")]
        [TestCase(999, "CMXCIX")]
        public void roman_dictionary(int input, string expectedResult)
        {
            //Arrange
             

            var getDigits = new Converter();
            
            //Act

           var actualResult =  getDigits.ToRoman(input);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    } 
}
