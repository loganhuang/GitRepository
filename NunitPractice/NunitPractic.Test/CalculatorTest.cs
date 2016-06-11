using NUnit.Framework;
using NunitPractice;

namespace NunitPractic.Tests
{
    [TestFixture]
    class CalculatorTest
    {
        [Test]
        public void ShouldAddTwoNumbers()
        {
            ICalculator cal = new Calculator();
            int num1 = 5;
            int num2 = 7;
            int actual = cal.Add(num1, num2);
            Assert.AreEqual(12,actual,0.001);
        }

        [Test]
        public void ShouldSubtractTwoNumbers()
        {
            ICalculator cal = new Calculator();
            int num1 = 7;
            int num2 = 5;
            int actual = cal.Subtract(num1, num2);
            Assert.AreEqual(2, actual, 0.001);
        }
        [TestCase(1,2)]
        [TestCase(3,5)]
        public void ShouldAddTwoNumbers(int num1, int num2)
        {
            ICalculator cal = new Calculator();
            int actual = cal.Add(num1, num2);
            Assert.AreEqual((num1+num2), actual, 0.001);
        }
    }
}
