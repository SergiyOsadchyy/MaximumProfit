using MaximumProfit.Models;

namespace MaximumProfit.Views
{
    public interface IProfitView
    {
        int[] GetRates();
        void ShowResult(Result result);
    }
}