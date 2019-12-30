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
        public void GetUserInput(object target, string propertyName)
        {
            PropertyInfo prop = target.GetType().GetProperty(propertyName);
            decimal val;

            Console.WriteLine($"Enter {prop.Name} (decimal): ");
            while (!decimal.TryParse(Console.ReadLine(), out val))
                Console.WriteLine("The value must be of decimal type, try again: ");

            prop.SetValue(target, val);
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
            SimpleCalc calc = new SimpleCalc();
            calc.GetUserInput(calc, nameof(SimpleCalc.A));
            calc.GetUserInput(calc, nameof(SimpleCalc.B));
            calc.GetOperation();
            calc.Evaluate();
            calc.PrintResult();      
        }
    }
}
