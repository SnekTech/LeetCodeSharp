namespace Interview150.DP._97;

public class Solution
{
    public bool IsInterleave(string s1, string s2, string s3)
    {
        int m = s1.Length, n = s2.Length, t = s3.Length;
        if (m + n != t)
            return false;

        var dp = new bool[m + 1, n + 1];
        dp[0, 0] = true;
        for (var i = 0; i <= m; i++)
        {
            for (var j = 0; j <= n; j++)
            {
                var p = i + j - 1;
                if (i > 0)
                {
                    dp[i, j] |= s1[i - 1] == s3[p] && dp[i - 1, j];
                }

                if (j > 0)
                {
                    dp[i, j] |= s2[j - 1] == s3[p] && dp[i, j - 1];
                }
            }
        }

        return dp[m, n];
    }
}