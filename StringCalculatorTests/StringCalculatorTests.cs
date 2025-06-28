using Microsoft.VisualStudio.TestPlatform.CoreUtilities.Extensions;
using NUnit.Framework;
using StringCalculatorKata;

namespace StringCalculatorTests
{
    [TestFixture]
    public class StringCalculatorTests
    {
        [Test]
        public void Add_EmptyString_ReturnZero()
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add("");

            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Add_SingleNumber_ReturnTheNumber()
        {
            StringCalculator calculator = new StringCalculator();

            int result = calculator.Add("2");

            Assert.That(result, Is.EqualTo(2));
        }
    }
}
