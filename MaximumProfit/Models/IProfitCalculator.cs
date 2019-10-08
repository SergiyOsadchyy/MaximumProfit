namespace MaximumProfit.Models
{
    public interface IProfitCalculator
    {
        Result CalculateResult(int[] rates);
    }
}