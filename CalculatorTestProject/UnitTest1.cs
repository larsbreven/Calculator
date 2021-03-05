using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        [Fact]  // Annotation, "Fact" is where Xunit is looking for when it's looking for the test methods to test
        public void AdditionTest()  // Initiate a test to see if the Addition-method work
        {
            // Arrange
            double result = Brain.Addition(1,1);
          
            // Act

            // Assert   // Assert that the result "Addition(1,1) is "Assert.Equal(2,result" , in other words 1+1 is equal to 2
            Assert.Equal(2, result);

        }

        [Fact]
        public void SubtractionTest()
        {

            double result = Brain.Subtraction(2, 1);
            Assert.Equal(1, result);

        }

        [Fact]
        public void MultiplicationTest()
        {

            double result = Brain.Multiplication(25,20);
            Assert.Equal(500, result);

        }

        [Fact]
        public void DivisonTest()
        {

            double result = Brain.Division(100,5);
            Assert.Equal(20, result);

        }














    }
}
