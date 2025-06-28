using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using NUnit.Framework;
using StringCalculatorKata;
using System.Security.AccessControl;

namespace StringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        private StringCalculator calculator;
        [SetUp]
        public void SetUp()
        {
            calculator = new StringCalculator();
        }

        [Test]
        public void Add_EmptyString_ReturnZero()
        {
            int result = calculator.Add("");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_SingleNumber_ReturnTheNumber()
        {
            int result1 = calculator.Add("2");
            int result2 = calculator.Add("10");

            Assert.That(result1, Is.EqualTo(2));
            Assert.That(result2, Is.EqualTo(10));
        }

        [Test]
        public void Add_TwoNumbers_ReturnSum()
        {
            int result1 = calculator.Add("1,2");
            int result2 = calculator.Add("4,5");

            Assert.That(result1, Is.EqualTo(3));
            Assert.That(result2, Is.EqualTo(9));
        }

        [Test]
        public void Add_UnkownNumbers_ReturnSum()
        {
            int result1 = calculator.Add("1,2");
            int result2 = calculator.Add("4,5,1");
            int result3 = calculator.Add("2,5,3,1,2,3");

            Assert.That(result1, Is.EqualTo(3));
            Assert.That(result2, Is.EqualTo(10));
            Assert.That(result3, Is.EqualTo(16));
        }

        [Test]
        public void Add_NewLineSeparator_ReturnSum()
        {
            int result1 = calculator.Add("1\n2,3");
            int result2 = calculator.Add("1,");

            Assert.That(result1, Is.EqualTo(6));
            Assert.That(result2, Is.EqualTo(1));
        }

    }
}
