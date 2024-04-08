namespace Interview150.DP._72;

public class Solution
{
    public int MinDistance(string word1, string word2)
    {
        int m = word1.Length, n = word2.Length;
        var dp = new int[m + 1, n + 1];
        dp[0, 0] = 0;

        for (var i = 1; i <= m; i++)
        {
            dp[i, 0] = i;
        }

        for (var j = 1; j <= n; j++)
        {
            dp[0, j] = j;
        }

        for (var i = 1; i <= m; i++)
        {
            for (var j = 1; j <= n; j++)
            {
                if (word1[i - 1] == word2[j - 1])
                {
                    dp[i, j] = Min3(dp[i - 1, j] + 1, dp[i, j - 1] + 1, dp[i - 1, j - 1]);
                }
                else
                {
                    dp[i, j] = Min3(dp[i - 1, j] + 1, dp[i, j - 1] + 1, dp[i - 1, j - 1] + 1);
                }
            }
        }

        return dp[m, n];

        int Min3(int a, int b, int c) => int.Min(a, int.Min(b, c));
    }
}