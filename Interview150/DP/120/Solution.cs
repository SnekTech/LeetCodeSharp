namespace Interview150.DP._120;

public class Solution
{
    public int MinimumTotal(IList<IList<int>> triangle)
    {
        int m = triangle.Count, n = triangle[^1].Count;
        var dp = new int[m, n];

        dp[0, 0] = triangle[0][0];
        for (var i = 1; i < m; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + triangle[i][0];
        }

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < i; j++)
            {
                dp[i, j] = int.Min(dp[i - 1, j - 1], dp[i - 1, j]) + triangle[i][j];
            }

            dp[i, i] = dp[i - 1, i - 1] + triangle[i][i];
        }

        var minPath = int.MaxValue;
        for (var j = 0; j < n; j++)
        {
            minPath = int.Min(minPath, dp[m - 1, j]);
        }

        return minPath;
    }
}