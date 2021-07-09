using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Calculator;

namespace Calculator.Tests
{
    [TestClass]
    public class ResultsTests
    {
        [TestMethod]
        public void Calculate_Below125000_Result0()
        {
            double purchasePrice = 70000;
            double result = CalculatorHelp.Calculate(purchasePrice);

            Assert.AreEqual(0, result);
        }
        [DataRow(125000,0)]
        [DataRow(925000, 36250)]
        [DataTestMethod]
        public void Calculate_Price_Result(int purchasePrice, int expectedStampDuty)
        {
            double actualStampDuty = CalculatorHelp.Calculate(purchasePrice);

            Assert.AreEqual(expectedStampDuty, actualStampDuty);
        }

        [TestMethod]
        public void Calculate_Price550k_Result17500()
        {
            double purchasePrice = 550000;
            double result = CalculatorHelp.Calculate(purchasePrice);

            Assert.AreEqual(17500, result);
        }

        [TestMethod]
        public void Calculate_Price900000k_Result35000()
        {
            double purchasePrice = 900000;
            double result = CalculatorHelp.Calculate(purchasePrice);

            Assert.AreEqual(35000, result);
        }

        [TestMethod]
        public void Calculate_PriceAbove1500000_Result67206()
        {
            double purchasePrice = 1234567;
            double result = CalculatorHelp.Calculate(purchasePrice);

            Assert.AreEqual(67206, result);
        }
    }
}
