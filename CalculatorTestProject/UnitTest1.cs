using System;
using Xunit;
using Calculator;

namespace Calculator.Tests
{
    public class UnitTest1
    {

        [Fact]                             
        public void AdditionTestPos()       // Test of addition method when positive decimal numbers are used
        {
            double result = Brain.Addition(1.545,1.455);                // Arrange
                                                                        // Act
            Assert.Equal(3, result);                                    // Assert
        }
        [Fact]
        public void AdditionTestNeg()       // Test of addition method when negative decimal numbers are used
        {
            double result = Brain.Addition(-8.9331,-6.7633);
            Assert.Equal(-15.6964, result,4);
        }
        [Fact]
        public void AdditionTestAdv()       // Test of addition method when positive/negative decimal numbers are used
        {
            double result = Brain.Addition(-0.6542, 658.32);
            Assert.Equal(657.6658, result,4);
        }

        [Fact]  
        public void AdditionArrTestPos()    // Test of addition method in an array when decimal numbers are used
        {
            double[] arrTestNumbers = {1.545,1.455};                    // Arrange
            double expected = 3;                                             
            double result;                                                          

            result = Brain.Addition(arrTestNumbers);                    // Act

            Assert.Equal(expected, result, 4);                          // Assert
        }


        [Fact]
        public void SubtractionTestPos()    // Test of subtraction method when positive decimal numbers are used
        {
            double result = Brain.Subtraction(1.545, 1.455);            // Arrange
                                                                        // Act
            Assert.Equal(0.09, result,4);                               // Assert
        }
        [Fact]
        public void SubtractionTestNeg()    // Test of subtraction method when negative decimal numbers are used
        {
            double result = Brain.Subtraction(-8.9331, -6.7633);
            Assert.Equal(-2.1698, result,4);
        }
        [Fact]
        public void SubtractionTestAdv()    // Test of subtraction method when positive/negative decimal numbers are used
        {
            double result = Brain.Subtraction(-0.6542, 658.32);
            Assert.Equal(-658.9742, result,4);
        }

        [Fact]  
        public void SubtractionArrTestPos()  // Test of subtraction method in an array when decimal numbers are used
        {
            double[] arrTestNumbers = { 1.545,1.455 };                  // Arrange
            double expected = -0.09;
            double result;

            result = Brain.Subtraction(arrTestNumbers);                 // Act

            Assert.Equal(expected, result, 4);                          // Assert
        }


        [Fact]
        public void MultiplicationTestPos() // Test of multiplication method when positive decimal numbers are used
        {
            double result = Brain.Multiplication(1.545, 1.455);         // Arrange
                                                                        // Act
            Assert.Equal(2.2480, result,4);                             // Assert
        }
        [Fact]
        public void MultiplicationTestNeg() // Test of multiplication method when negative decimal numbers are used
        {
            double result = Brain.Multiplication(-8.9331, -6.7633);
            Assert.Equal(60.4172, result,4);
        }
        [Fact]
        public void MultiplicationTestAdv() // Test of multiplication method when positive/negative decimal numbers are used
        {
            double result = Brain.Multiplication(-0.6542, 658.32);
            Assert.Equal(-430.6729, result,4);
        }


        [Fact]
        public void DivisionTestPos()       // Test of division method when positive decimal numbers are used
        {
            double result = Brain.Division(1.545, 1.455);               // Arrange
                                                                        // Act
            Assert.Equal(1.06186, result,4);                            // Assert
        }
        [Fact]
        public void DivisionTestNeg()       // Test of division method when negative decimal numbers are used
        {
            double result = Brain.Division(-8.9331, -6.7633);
            Assert.Equal(1.3208, result,4);
        }
        [Fact]
        public void DivisionTestAdv()       // Test of division method when positive/negative decimal numbers are used
        {
            double result = Brain.Division(-0.6542, 658.32);
            Assert.Equal(-0.0010, result,4);
        }

        [Fact]
        public void DivisionTestZero()      // Test of division method when divided by zero
        {
            double result = Brain.Division(0, 658.32);
            Assert.Equal(0, result);
        }
    }
}
