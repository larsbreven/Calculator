using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {
        
        [Fact]  // Annotation, "Fact" is where Xunit is looking for when it's looking for the test methods to test
        public void AdditionTestPos()  // Run to check the addition method when positive decimal numbers are used
        {
            double result = Brain.Addition(1.545,1.455);                // Arrange
                                                                        // Act
            Assert.Equal(3, result);                                    // Assert
        }
        [Fact]
        public void AdditionTestNeg()  // Run to check the addition method when negative decimal numbers are used
        {
            double result = Brain.Addition(-8.9331,-6.7633);
            Assert.Equal(-15.6964, result);
        }
        [Fact]
        public void AdditionTestAdv()  // Run to check the addition method when positive/negative decimal numbers are used
        {
            double result = Brain.Addition(-0.6542, 658.32);
            Assert.Equal(657.6658000000001, result);
        }


        [Fact]
        public void SubtractionTestPos()  // Run to check the subtraction method when positive decimal numbers are used
        {
            double result = Brain.Subtraction(1.545, 1.455);                // Arrange
                                                                            // Act
            Assert.Equal(0.08999999999999986, result);                      // Assert
        }
        [Fact]
        public void SubtractionTestNeg()  // Run to check the subtraction method when negative decimal numbers are used
        {
            double result = Brain.Subtraction(-8.9331, -6.7633);
            Assert.Equal(-2.1697999999999995, result);
        }
        [Fact]
        public void SubtractionTestAdv()  // Run to check the subtraction method when positive/negative decimal numbers are used
        {
            double result = Brain.Subtraction(-0.6542, 658.32);
            Assert.Equal(-658.9742, result);
        }


        [Fact]
        public void MultiplicationTestPos()  // Run to check the multiplication method when positive decimal numbers are used
        {
            double result = Brain.Multiplication(1.545, 1.455);             // Arrange
                                                                            // Act
            Assert.Equal(2.247975, result);                                 // Assert
        }
        [Fact]
        public void MultiplicationTestNeg()  // Run to check the multiplication method when negative decimal numbers are used
        {
            double result = Brain.Multiplication(-8.9331, -6.7633);
            Assert.Equal(60.417235229999996, result);
        }
        [Fact]
        public void MultiplicationTestAdv()  // Run to check the multiplication method when positive/negative decimal numbers are used
        {
            double result = Brain.Multiplication(-0.6542, 658.32);
            Assert.Equal(-430.67294400000003, result);
        }


        [Fact]
        public void DivisionTestPos()  // Run to check the division method when positive decimal numbers are used
        {
            double result = Brain.Division(1.545, 1.455);                   // Arrange
                                                                            // Act
            Assert.Equal(1.0618556701030928, result);                       // Assert
        }
        [Fact]
        public void DivisionTestNeg()  // Run to check the division method when negative decimal numbers are used
        {
            double result = Brain.Division(-8.9331, -6.7633);
            Assert.Equal(1.3208197181849097, result);
        }
        [Fact]
        public void DivisionTestAdv()  // Run to check the division method when positive/negative decimal numbers are used
        {
            double result = Brain.Division(-0.6542, 658.32);
            Assert.Equal(-0.000993741645400413, result);
        }

        [Fact]
        public void DivisionTestZero()  // Run to check the division method when divided by zero
        {
            double result = Brain.Division(0, 658.32);
            Assert.Equal(0, result);
        }







    }
}
