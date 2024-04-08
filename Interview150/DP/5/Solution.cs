namespace Interview150.DP._5;

public class Solution
{
    public string LongestPalindrome(string s)
    {
        var n = s.Length;
        if (n < 2)
            return s;

        int maxLen = 1, begin = 0;
        var dp = new bool[n, n];
        for (var i = 0; i < n; i++)
        {
            dp[i, i] = true;
        }

        // iterate over the palindrome length
        for (var len = 2; len <= n; len++)
        {
            for (var i = 0; i < n; i++)
            {
                // j - i + 1 = len
                var j = len + i - 1;
                if (j >= n)
                {
                    break;
                }

                if (s[i] != s[j])
                {
                    dp[i, j] = false;
                }
                else
                {
                    if (j - i < 3)
                    {
                        dp[i, j] = true;
                    }
                    else
                    {
                        dp[i, j] = dp[i + 1, j - 1];
                    }
                }

                if (dp[i, j] && j - i + 1 > maxLen)
                {
                    maxLen = j - i + 1;
                    begin = i;
                }
            }
        }

        return s.Substring(begin, maxLen);
    }
}