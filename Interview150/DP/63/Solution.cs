namespace Interview150.DP._63;

public class Solution
{
    public int UniquePathsWithObstacles(int[][] obstacleGrid)
    {
        int m = obstacleGrid.Length, n = obstacleGrid[0].Length;
        var dp = new int[m, n];
        dp[0, 0] = obstacleGrid[0][0] == 1 ? 0 : 1;

        for (var i = 1; i < m; i++)
        {
            if (obstacleGrid[i][0] != 0 || dp[i - 1, 0] == 0)
                break;

            dp[i, 0] = 1;
        }

        for (var j = 1; j < n; j++)
        {
            if (obstacleGrid[0][j] != 0 || dp[0, j - 1] == 0)
                break;

            dp[0, j] = 1;
        }

        for (var i = 1; i < m; i++)
        {
            for (var j = 1; j < n; j++)
            {
                if (obstacleGrid[i][j] != 0)
                {
                    dp[i, j] = 0;
                    continue;
                }

                dp[i, j] = dp[i - 1, j] + dp[i, j - 1];
            }
        }

        return dp[m - 1, n - 1];
    }
}