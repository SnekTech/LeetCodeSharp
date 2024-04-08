namespace Interview150.DP._64;

public class Solution
{
    public int MinPathSum(int[][] grid)
    {
        int m = grid.Length, n = grid[0].Length;
        var dp = new int[m, n];
        dp[0, 0] = grid[0][0];

        for (var i = 1; i < m; i++)
        {
            dp[i, 0] = dp[i - 1, 0] + grid[i][0];
        }

        for (var j = 1; j < n; j++)
        {
            dp[0, j] = dp[0, j - 1] + grid[0][j];
        }

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                dp[i, j] = int.Min(dp[i - 1, j], dp[i, j - 1]) + grid[i][j];
            }
        }

        return dp[m - 1, n - 1];
    }
}