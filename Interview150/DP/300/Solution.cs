namespace Interview150.DP._300;

public class Solution
{
    public int LengthOfLIS(int[] nums)
    {
        var n = nums.Length;
        var maxLen = 1;
        var dp = new int[n];
        Array.Fill(dp, 1);

        for (var i = 1; i < n; i++)
        {
            for (var j = i - 1; j >= 0; j--)
            {
                if (nums[j] < nums[i])
                {
                    dp[i] = Math.Max(dp[i], dp[j] + 1);
                }
            }

            maxLen = Math.Max(maxLen, dp[i]);
        }

        return maxLen;
    }
}