﻿using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SimpleCalc
    {   
        // methods
        public decimal GetUserInput(string argTextInput)
        {
            decimal convertedNumber;
            if (!decimal.TryParse(argTextInput, out convertedNumber))
                throw new ArgumentException("Expected a numeric value.");

            return convertedNumber;
        }
        
        public decimal Evaluate(string argOperation, decimal argFirstNumber, decimal argSecondNumber)
        {
            decimal result;
            switch (argOperation)
            {
                case "+":
                case "add":
                    result = argFirstNumber + argSecondNumber;
                    break;
                case "-":
                case "subtract":
                    result = argFirstNumber - argSecondNumber;
                    break;
                case "*":
                case "multiply":
                    result = argFirstNumber * argSecondNumber;
                    break;
                case "/":
                case "divide":
                    result = argFirstNumber / argSecondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Invalid operator specified.");
            }
            return result;
        }

        public void PrintResult(decimal argResult)
        {
            Console.WriteLine($"Result: {argResult}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
               
                decimal firstNumber = inputConverter.GetUserInput(Console.ReadLine());
                decimal secondNumber = inputConverter.GetUserInput(Console.ReadLine());
                string operation = Console.ReadLine();
                decimal result = calculatorEngine.Evaluate(operation, firstNumber, secondNumber);
                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
