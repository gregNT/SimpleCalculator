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
            string inputText = "4";
            decimal result = _inputConverter.ConvertStringNumberToDouble(inputText);
            Assert.AreEqual(4m, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FailsToConvertInvalidStringInputIntoDouble()
        {
            string inputText = "*";
            decimal result = _inputConverter.ConvertStringNumberToDouble(inputText);
        }
    }
}
