using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleCalculator.Test.Unit
{
    [TestClass]
    public class CalculatorEngineTest
    {
        private readonly CalculatorEngine _calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForNonSymbolOperation()
        {
            decimal firstNumber = 10m;
            decimal secondNumber = 2m;
            string operation = "-";
            decimal result = _calculatorEngine.Evaluate(operation, firstNumber, secondNumber);
            Assert.AreEqual(8m, result);
        }

        [TestMethod]
        public void AddsTwoNumbersAndReturnsValidResultForSymbolOperation()
        {
            decimal firstNumber = 10m;
            decimal secondNumber = 2m;
            string operation = "subtract";
            decimal result = _calculatorEngine.Evaluate(operation, firstNumber, secondNumber);
            Assert.AreEqual(8m, result);
        }
    }
}
