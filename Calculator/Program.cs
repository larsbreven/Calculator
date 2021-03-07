using System;

namespace Calculator
{ 
        class Program
        {
            static void Main(string[] args)
            {
            Console.WriteLine();
            Console.WriteLine("Please use our basic calculator to do a calculation");
            Console.WriteLine("It is easy to use, just follow the instructions below");
            Console.WriteLine();
            Console.WriteLine();
            do
                {
                Console.WriteLine("Enter a number from the menu below for the desired calculation");
                Console.WriteLine("\n1: Addition\n2: Subtraction\n3: Multiplication\n4: Division\n");
                char userInput = Console.ReadKey(true).KeyChar;
                Console.WriteLine("");
                Console.Write("Enter the first number to be calculated : ");
                double FirstNum = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the second number to be calculated: ");
                double SecondNum = Convert.ToDouble(Console.ReadLine());

                double[] numArray = new double[2];  // ***************** Overload method********************
                numArray[0] = FirstNum;
                numArray[1] = SecondNum;

                switch (userInput)
                {
                    case '1':
                        Brain.Addition(numArray[0], numArray[1]);
                    break;

                    case '2':
                        Brain.Subtraction(numArray[0],numArray[1]);
                    break;

                    case '3':
                        Brain.Multiplication(FirstNum,SecondNum);
                    break;

                    case '4':
                        if (SecondNum == 0)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("You have entered: " + SecondNum);
                            Console.WriteLine("Please note the entered value is not valid");
                            return;
                        }
                        Brain.Division(FirstNum,SecondNum);
                    break;

                    default:
                    break;
                    }
                Console.WriteLine();
                Console.WriteLine("Press c to continue, any other key to exit the calculator ");
                }
            while (Console.ReadKey(true).KeyChar == 'c');
            }
        }
}