using System;
using System.IO;
using MaximumProfit.Models;
using MaximumProfit.Views;
using NUnit.Framework;

namespace MaximumProfit_Tests.Views
{
    [TestFixture]
    public class ProfitViewTests
    {
        [Test]
        public void ShowResul_WritesResultToConsole()
        {
            using (StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                
                Result result = new Result { BuyPrice = 1, SellPrice = 3, MaximumProfit = 2 };
                ProfitView view = new ProfitView();
                string expected = 
                    string.Format($"buy at {result.BuyPrice} and sell at {result.SellPrice} for a maximum profit of {result.MaximumProfit}{Environment.NewLine}");
                
                view.ShowResult(result);
                
                Assert.AreEqual(expected, sw.ToString());
            }
        }
    }
}