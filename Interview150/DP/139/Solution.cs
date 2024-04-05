namespace Interview150.DP._139;

public class Solution
{
    public bool WordBreak(string s, IList<string> wordDict)
    {
        var n = s.Length;
        var dp = new bool[n];
        for (var i = 0; i < n; i++)
        {
            var isBreakable = false;
            foreach (var word in wordDict)
            {
                if (i < word.Length - 1)
                {
                    continue;
                }
                else if (i == word.Length - 1)
                {
                    isBreakable |= s[..(i + 1)].Equals(word);
                }
                else
                {
                    isBreakable |= dp[i - word.Length] && s[(i - word.Length + 1)..(i + 1)].Equals(word);
                }

                if (isBreakable)
                {
                    break;
                }
            }

            dp[i] = isBreakable;
        }

        return dp[n - 1];
    }
}