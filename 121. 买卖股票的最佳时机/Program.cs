using System.Data;

namespace _121._买卖股票的最佳时机
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 6, 4, 3, 1 };
            int result = MaxProfit(prices);
            Console.WriteLine(result);
        }

        public static int MaxProfit(int[] prices)
        {
            int minPrice = int.MaxValue;
            int minPriceIndex = 0;
            int maxProfit = 0;
            for (int i = 0, imax = prices.Length ; i < imax; i++) 
            {
                if (prices[i] < minPrice) 
                {
                    minPrice = prices[i];
                    minPriceIndex = i;
                }
            }

            for (int i = minPriceIndex; i < prices.Length; i++) 
            {
                int profit = prices[i] - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                }
            }


            return maxProfit;
        }
    }
}
