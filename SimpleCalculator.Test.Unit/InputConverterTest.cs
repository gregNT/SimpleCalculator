using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class InputConverterTest
    {
        private readonly InputConverter _inputConverter = new InputConverter();
        [TestMethod]
        public void ConvertsValidStringInputIntoDouble()
        {

        }

        [TestMethod]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
        }
    }
}
