using MaximumProfit.Models;
using MaximumProfit.Views;

namespace MaximumProfit.Controllers
{
    public class ProfitController
    {
        private IProfitCalculator _calculator;
        private IProfitView _view;
        
        public ProfitController(IProfitCalculator calculator, IProfitView view)
        {
            _calculator = calculator;
            _view = view;
            _view.ShowResult(_calculator.CalculateResult(_view.GetRates()));
        }

        public ProfitController() : this(
            new ProfitCalculator(),
            new ProfitView())
        { }
    }
}