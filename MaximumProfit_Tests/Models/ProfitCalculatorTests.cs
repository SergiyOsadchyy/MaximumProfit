using MaximumProfit.Models;
using NUnit.Framework;

namespace Tests.Models
{
    [TestFixture]
    public class ProfitCalculatorTests
    {
        private ProfitCalculator _calculator;
        
        [SetUp]
        public void SetUp()
        {
            _calculator = new ProfitCalculator();
        }

        [Test]
        public void CalculateResult_ReturnsEmptyResult_WhenCalledWithEmptyArray()
        {
            int[] rates = {};

            Result actual = _calculator.CalculateResult(rates);
            
            Assert.AreEqual(0, actual.BuyPrice);
            Assert.AreEqual(0, actual.SellPrice);
            Assert.AreEqual(0, actual.MaximumProfit);
        }
        
        [Test]
        public void CalculateResult_ReturnsResult_WhenCalledWithOneElementArray()
        {
            int[] rates = {1};

            Result actual = _calculator.CalculateResult(rates);
            
            Assert.AreEqual(1, actual.BuyPrice);
            Assert.AreEqual(1, actual.SellPrice);
            Assert.AreEqual(0, actual.MaximumProfit);
        }
        
        [Test]
        public void CalculateResult_ReturnsResult()
        {
            int[] rates = {4, 2, 8, 6, 7, 12, 3, 25, 21, 30, 1};

            var actual = _calculator.CalculateResult(rates);
            
            Assert.IsInstanceOf<Result>(actual);
            Assert.AreEqual(2, actual.BuyPrice);
            Assert.AreEqual(30, actual.SellPrice);
            Assert.AreEqual(28, actual.MaximumProfit);
        }
    }
}
