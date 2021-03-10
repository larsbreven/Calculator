using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    public class Brain
    {

       public static double Addition(double FirstNum, double SecondNum)
        {
            double TheResult = FirstNum + SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
            return TheResult;
        }

        public static double Addition(double[] numbers)     // Overloaded method of Addition that takes a double array as input parameter
        {                   
            double sum = 0;
            foreach (double num in numbers)
            {
                sum = num + sum;
            }
            return sum;
        }


        public static double Subtraction(double FirstNum, double SecondNum)
        {
            double TheResult = FirstNum - SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
            return TheResult;
        }

        public static double Subtraction(double[] numbers)  // Overloaded method of Subtraction that takes a double array as input parameter
        {
            double sum = 0;
            foreach (double num in numbers)
            {
                sum = num - sum;
            }
            return sum;
        }


            public static double Multiplication(double FirstNum, double SecondNum)
        {
            double TheResult = FirstNum * SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
            return TheResult;
        }


        public static double Division(double FirstNum, double SecondNum)
        {
            double TheResult = FirstNum / SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
            return TheResult;
        }
    }
}