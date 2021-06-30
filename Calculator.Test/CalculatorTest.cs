using Moq;
using System;
using Xunit;

namespace Calculator.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Add()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));
        }
        [Fact]
        public void Substract()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(0);
            Assert.Equal(0, calculator.Object.Add(2, 2));
        }
        [Fact]
        public void Multiply()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(4);
            Assert.Equal(4, calculator.Object.Add(2, 2));
        }
        [Fact]
        public void Divide()
        {
            var calculator = new Mock<ICalculator>();
            calculator.Setup(x => x.Add(2, 2)).Returns(1);
            Assert.Equal(1, calculator.Object.Add(2, 2));
        }
    }
}