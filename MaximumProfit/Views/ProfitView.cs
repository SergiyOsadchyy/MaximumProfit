using System;
using MaximumProfit.Models;

namespace MaximumProfit.Views
{
    public class ProfitView : IProfitView
    {
        public int[] GetRates()
        {
            Console.WriteLine("Please, enter int values separated by space");
            int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), value => Convert.ToInt32(value));
            return ar;
        }

        public void ShowResult(Result result)
        {
            Console.WriteLine($"buy at {result.BuyPrice} and sell at {result.SellPrice} for a maximum profit of {result.MaximumProfit}");
        }
    }
}