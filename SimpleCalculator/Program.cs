using System;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
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
