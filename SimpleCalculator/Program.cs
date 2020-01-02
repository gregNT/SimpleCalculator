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
        // private members
        Dictionary<string, string> _allowedOperations = new Dictionary<string, string> {
            {"+", "+" },
            {"add", "+" },
            {"-", "-" },
            {"subtract", "-"},
            {"*", "*"},
            {"multiply", "*"},
            {"/", "/"},
            {"divide", "/"}
        };
        // auto-properties
        public decimal A { get; set; }
        public decimal B { get; set; }
        public string Operation { get; set; }
        public decimal Result { get; set; }
        
        // methods
        public decimal GetUserInput(string argTextInput)
        {
            decimal convertedNumber;
            if (!decimal.TryParse(argTextInput, out convertedNumber))
                throw new ArgumentException("Expected a numeric value.");

            return convertedNumber;
        }

        public void GetOperation()
        {
            string operation = null;

            Console.WriteLine($"Enter operator: ");
            while (!_allowedOperations.TryGetValue(Console.ReadLine().ToLower(), out operation))
                Console.WriteLine("Invalid operator. Try again: ");
            
            Operation = operation;
        }
        
        public void Evaluate()
        {
            switch (Operation)
            {
                case "+":
                    Result = A + B;
                    break;
                case "-":
                    Result = A - B;
                    break;
                case "*":
                    Result = A * B;
                    break;
                case "/":
                    Result = A / B;
                    break;
            }
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
                /*decimal result = calc.Evaluate();
                calc.PrintResult(result); */
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
