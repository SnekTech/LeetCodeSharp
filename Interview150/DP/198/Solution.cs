namespace Interview150.DP._198;

public class Solution
{
    public int Rob(int[] nums)
    {
        var n = nums.Length;
        var dp = new int[n];
        dp[0] = nums[0];
        if (n == 1)
            return dp[0];

        dp[1] = Math.Max(dp[0], nums[1]);

        for (var i = 2; i < n; i++)
        {
            dp[i] = Math.Max(dp[i - 2] + nums[i], dp[i - 1]);
        }

        return dp[^1];
    }
}