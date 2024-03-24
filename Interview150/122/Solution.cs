namespace Interview150._122;

public class Solution
{
    public int MaxProfit(int[] prices)
    {
        int n = prices.Length;
        if (n < 2) return 0;

        int[,] dp = new int[n, 2];
        dp[0, 0] = 0;
        dp[0, 1] = -prices[0];

        for (int i = 1; i < n; i++)
        {
            dp[i, 0] = Math.Max(dp[i - 1, 0], dp[i - 1, 1] + prices[i]);
            dp[i, 1] = Math.Max(dp[i - 1, 1], dp[i - 1, 0] - prices[i]);
        }

        return dp[n - 1, 0];
    }
}