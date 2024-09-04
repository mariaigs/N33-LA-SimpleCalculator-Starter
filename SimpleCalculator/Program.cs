﻿using System;
using CalculatorEngine;


namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Class to perform actual calculations
                CalculatorEngine calculatorEngine = new CalculatorEngine();

                double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());

                //string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                //Console.WriteLine(result);

            }
            catch (Exception ex)
            {
                // Normally, we'd log this error to a file.
                Console.WriteLine(ex.Message);
            }

        }
        static double GetValidNumber(string prompt)
        {
            double number = 0;
            do {
                Console.WriteLine(prompt);
                string input = Console.ReadLine();
                InputConverter.ConvertInputToNumeric(input, out number);

                if (number == 0)
                    Console.WriteLine("Invalid input. Please enter a valid number.");

            } while (number == 0);
            return number;
        }
        static string GetValidOperation()
        {
            while (true)
            {
                Console.WriteLine("Enter the operation: ");
                string operation = Console.ReadLine().Trim().ToLower();
                if (IsValidOperation(operation))
                {
                    return operation;
                }
                Console.WriteLine("Invalid operation. Valid operations are:");
                Console.WriteLine("+ or add for addtion");
                Console.WriteLine("- or subtract for subtraction");
                Console.WriteLine("* or multiply for multiplcation");
                Console.WriteLine("/ or divide for division");

            }
        }
        static bool IsValidOperation(string operation)
        {
            return operation == "+" || operation == "add" ||
                operation == "-" || operation == "subtract" ||
                operation == "*" || operation == "multiply" ||
                operation == "/" || operation== "divide";
        }
    }
}
