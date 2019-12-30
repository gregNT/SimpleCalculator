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
        // properties
        public decimal A { get; set; }
        public decimal B { get; set; }
        public string operation { get; set; }
        
        public void GetUserInput(object target, string propertyName)
        {
            PropertyInfo prop = target.GetType().GetProperty(propertyName);
            decimal val;

            Console.WriteLine("Enter value (decimal): ");
            while (!decimal.TryParse(Console.ReadLine(), out val))
                Console.WriteLine("The value must be of decimal type, try again: ");

            prop.SetValue(target, val);
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
