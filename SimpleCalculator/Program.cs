using System;
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

        public void PrintResult()
        {
            Console.WriteLine($"Result: {Result}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                SimpleCalc calc = new SimpleCalc();
                decimal firstNumber = calc.GetUserInput(Console.ReadLine());
                decimal secondNumber = calc.GetUserInput(Console.ReadLine());
                string operation = Console.ReadLine();
                decimal result = calc.Evaluate(operation, firstNumber, secondNumber);
                //calc.PrintResult(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
