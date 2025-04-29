using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_w9_1;

namespace Homework_w9_1_Tests
{
    [TestClass]
    public class VATCalculatorTests
    {
        private VATCalculator calculator;

        [TestInitialize]
        public void Setup()
        {
            calculator = new VATCalculator();
        }

        [TestMethod]
        public void Test_FindVATFromPrice()
        {
            Assert.AreEqual(4.00, calculator.FindVATFromPrice(20));
        }

        [TestMethod]
        public void Test_FindPrice_WithTax()
        {
            Assert.AreEqual(16.67, calculator.FindPrice(true, 20));
        }

        [TestMethod]
        public void Test_FindPrice_WithoutTax()
        {
            Assert.AreEqual(24.00, calculator.FindPrice(false, 20));
        }

        [TestMethod]
        public void Test_FindPriceBasedOnTax()
        {
            Assert.AreEqual(20.00, calculator.FindPriceBasedOnTax(4));
        }

        [TestMethod]
        public void Test_IsTaxPercent20_True()
        {
            Assert.IsTrue(calculator.IsTaxPercent20());
        }

        [TestMethod]
        public void Test_IsTaxPercent20_False()
        {
            calculator.SetVATValue(9);
            Assert.IsFalse(calculator.IsTaxPercent20());
        }

        [TestMethod]
        public void Test_FindVATFromPrice_CustomRate()
        {
            calculator.SetVATValue(10);
            Assert.AreEqual(2.00, calculator.FindVATFromPrice(20));
        }

        [TestMethod]
        public void Test_FindPriceBasedOnTax_CustomRate()
        {
            calculator.SetVATValue(10);
            Assert.AreEqual(20.00, calculator.FindPriceBasedOnTax(2));
        }
    }
}
