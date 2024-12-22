using System.Data;

namespace _121._买卖股票的最佳时机
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4 };
            int result = MaxProfit(prices);
            Console.WriteLine(result);
        }

        /// <summary>
        /// 一遍遍历就够了
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices) 
        {
            int minPrice = prices[0];
            int maxProfit = 0;
            for (int i = 0, imax = prices.Length; i < imax; i++) 
            {
                if (prices[i] < minPrice)
                {
                    minPrice = prices[i];
                    continue;
                }
                int profit = prices[i] - minPrice;
                if (profit > maxProfit) 
                {
                    maxProfit = profit;
                }
            }
            return maxProfit;
        }

        public static int MaxProfit1(int[] prices)
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
