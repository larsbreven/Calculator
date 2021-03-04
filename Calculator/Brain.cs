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

        public static double Addition(double[] numArray)
        {
            return 1;
        }

        public static double Subtraction(double FirstNum, double SecondNum)
        {

            double TheResult = FirstNum - SecondNum;
            Console.WriteLine("The result of the calculation is:         " + TheResult);
            return TheResult;
        }
    }
}
