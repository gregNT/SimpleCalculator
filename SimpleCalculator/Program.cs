using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    public class SimpleCalc
    {
        // auto-properties
        public decimal a { get; set; }
        public decimal b { get; set; }
        public string operation { get; set; }

        // methods
        public void GetUserInput()
        {

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
