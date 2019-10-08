namespace MaximumProfit.Models
{
    public class ProfitCalculator : IProfitCalculator
    {
        public Result CalculateResult(int[] rates)
        {
            int length = rates.Length;
            if (length == 0)
            {
                return new Result();
            }
            if (length == 1)
            {
                return new Result {BuyPrice = rates[0], SellPrice = rates[0], MaximumProfit = 0};
            }
            
            int buyPrice = rates[length - 2];
            int sellPrice = rates[length - 1];
            int maximumProfit = sellPrice - buyPrice;

            for (int i = length - 2; i >= 0; i--)
            {
                if (rates[i] > sellPrice)
                {
                    sellPrice = rates[i];
                }
                else
                {
                    int diff = sellPrice - rates[i];
                    if (diff > maximumProfit)
                    {
                        buyPrice = rates[i];
                        maximumProfit = diff;
                    }
                }
            }

            Result result = new Result { BuyPrice = buyPrice, SellPrice = sellPrice, MaximumProfit = maximumProfit };
            return result;
        }
    }
}