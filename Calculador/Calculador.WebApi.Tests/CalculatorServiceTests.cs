using Calculator.Models;
using Calculator.Services;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorServiceTests
    {
        CalculatorService calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new CalculatorService();
        }

        [Test]
        public void Add_ReturnsCorrectResult()
        {
            Operation operation = new Operation { Number1 = 5, Number2 = 3 };
            Assert.AreEqual(8, calculator.Add(operation));
        }

        [Test]
        public void Subtract_ReturnsCorrectResult()
        {
            Operation operation = new Operation { Number1 = 5, Number2 = 3 };
            Assert.AreEqual(2, calculator.Subtract(operation));
        }

        [Test]
        public void Multiply_ReturnsCorrectResult()
        {
            Operation operation = new Operation { Number1 = 5, Number2 = 3 };
            Assert.AreEqual(15, calculator.Multiply(operation));
        }

        [Test]
        public void Divide_ReturnsCorrectResult()
        {
            Operation operation = new Operation { Number1 = 10, Number2 = 2 };
            Assert.AreEqual(5, calculator.Divide(operation));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Operation operation = new Operation { Number1 = 10, Number2 = 0 };
            Assert.Throws<System.DivideByZeroException>(() => calculator.Divide(operation));
        }
    }
}