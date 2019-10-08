using MaximumProfit.Controllers;
using MaximumProfit.Models;
using MaximumProfit.Views;
using Moq;
using NUnit.Framework;

namespace MaximumProfit_Tests.Controllers
{
    [TestFixture]
    public class ProfitControllerTests
    {
        private Mock<IProfitCalculator> _calculator;
        private Mock<IProfitView> _view;

        [SetUp]
        public void SetUp()
        {
            _calculator = new Mock<IProfitCalculator>();
            _view = new Mock<IProfitView>();
        }

        [Test]
        public void ProfitController_CallMethodsOnce()
        {
            new ProfitController(_calculator.Object, _view.Object);
            
            _view.Verify(v => v.GetRates(), Times.Once);
            _calculator.Verify(c => c.CalculateResult(It.IsAny<int[]>()), Times.Once);
            _view.Verify(v => v.ShowResult(It.IsAny<Result>()), Times.Once);
        }
    }
}