namespace Best_Time_to_Buy_and_Sell_Stock_121
{
    public class Solution
    {
        public int MaxProfit(int[] prices)
        {
            if (prices.Length == 0)
            {
                return 0;
            }

            int biggest = 0;
            int min = prices[0];

            for (int i = 0; i < prices.Length; i++)
            {
                if (prices[i] > min)
                {
                    if (prices[i] - min > biggest)
                    {
                        biggest = prices[i] - min;
                    }
                }
                else
                {
                    min = prices[i];
                }
                
            }

            return biggest;
            
        }
    }
}