using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            // this variable stores the previous result for reuse
            double memory = 0;


            // this loop repeats the calculator operations until the user decides to exit in the end by typing "exit"
            while (true)
            {

                // this code runs the calculator operations
                Console.WriteLine($"Write M to reuse the previous result: {memory} press Enter to continue to first Number");
                double firstNumber;

                string input = Console.ReadLine();
                if (input == "M")
                {
                    firstNumber = memory;
                }
                else
                {
                    Console.WriteLine("Enter first number:");
                    firstNumber = double.Parse(Console.ReadLine());
                }

                    Console.WriteLine("Give Me The Operation (+, -, *, /, %, ^):");
                string operation = Console.ReadLine();

                Console.WriteLine("Enter second number:");
                double secondNumber = double.Parse(Console.ReadLine());

                // this stores the result of the calculation
                double result = 0;

                // this performs the calculation based on the operator provided
                if (operation == "+")
                {
                    result = firstNumber + secondNumber;
                }
                else if (operation == "-")
                {
                    result = firstNumber - secondNumber;
                }
                else if (operation == "*")
                {
                    result = firstNumber * secondNumber;
                }
                else if (operation == "/")
                {
                    result = firstNumber / secondNumber;

                    // this checks for division by zero and handles it appropriately
                    if (firstNumber == 0 || secondNumber == 0)
                    {
                        Console.WriteLine("Error: Division by zero is not allowed.");
                        return;
                    }
                    // this performs the division if both numbers are non-zero
                    else
                    {
                        result = firstNumber / secondNumber;
                    }
                }
                else if (operation == "%")
                {
                    result = firstNumber % secondNumber;
                }
                else if (operation == "^")
                {
                    result = Math.Pow(firstNumber, secondNumber);
                }
                else
                {
                    // this prints when the operator is not based on the four basic operations (+ - * /)
                    Console.WriteLine("Invalid operator");
                }

                // this prints the result of the calculation
                Console.WriteLine("--------------------");
                Console.WriteLine($"{firstNumber} {operation} {secondNumber} = {result:F2}");
                Console.WriteLine("--------------------");
                memory = result;
                
                // this asks the user if they want to exit or continue
                Console.WriteLine("Type 'exit' to quit or press Enter to continue.");

                // this handles the user's decision to exit by checking if they typed "exit"
                string exit = Console.ReadLine();
                if (exit == "exit")
                {
                    break;
                }
            }

        }
    }
}
