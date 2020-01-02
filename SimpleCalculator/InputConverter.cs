using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator
{
    class InputConverter
    {
        public decimal GetUserInput(string argTextInput)
        {
            decimal convertedNumber;
            if (!decimal.TryParse(argTextInput, out convertedNumber))
                throw new ArgumentException("Expected a numeric value.");

            return convertedNumber;
        }
    }
}
