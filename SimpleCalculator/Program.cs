using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SimpleCalc
    {
        // properties
        decimal _a;
        decimal _b;

        public string operation { get; set; }

        // methods
        public void SetA() {
            Console.WriteLine("Enter a (decimal): ");
            while (!decimal.TryParse(Console.ReadLine(), out _a))
                Console.WriteLine("The value must be of decimal type, try again: ");
        }

        public void SetB()
        {
            Console.WriteLine("Enter b (decimal): ");
            while (!decimal.TryParse(Console.ReadLine(), out _b))
                Console.WriteLine("The value must be of decimal type, try again: ");
        }             
        
        public void GetUserInput()
        {
            SetA();
            SetB();
            /*
            do
            {
                
                isNumeric = 
                if (isNumeric)
                    a = val;
                else
                    Console.WriteLine("Error! Please specify the correct numeric value.");
            } while (!isNumeric);

            do
            {
                Console.WriteLine("Specify the second input (b): ");
                isNumeric = decimal.TryParse(Console.ReadLine(), out val);
                if (isNumeric)
                    b = val;
                else
                    Console.WriteLine("Error! Please specify the correct numeric value.");
            } while (!isNumeric);
            */
        }
        

        public decimal Evaluate()
        {
            return 0m;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalc calc = new SimpleCalc();
            calc.GetUserInput();
        }
    }
}
