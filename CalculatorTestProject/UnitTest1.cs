using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void AdditionTest()
        {
            
            double result = Brain.Addition(1, 1);
            Assert.Equal(2, result);

        }

        [Fact]
        public void SubtractionTest()
        {

            double result = Brain.Subtraction(2, 1);
            Assert.Equal(1, result);

        }
    }
}
