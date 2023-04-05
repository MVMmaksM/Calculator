using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Tests
{
    [TestFixture]
    internal class CalculatorTest
    {
        [Test]
        public void AdditionalMustReturnCorrectValue() 
        { 
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Additional(10, 20) == 30);
        }

        [Test]
        public void SubstractionReturnsCorrectValue() 
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Substraction(300, 20) == 280);
        }
    }
}
