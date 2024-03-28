namespace Interview150._3;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        HashSet<char> uniqueLetters = [];
        int n = s.Length;
        if (n <= 1) return n;

        int left = 0, right = 1, maxLen = 1;
        uniqueLetters.Add(s[left]);

        while (right < n)
        {
            var c = s[right];
            if (!uniqueLetters.Contains(c))
            {
                uniqueLetters.Add(c);
                maxLen = Math.Max(maxLen, right - left + 1);
            }
            else
            {
                while (s[left] != c)
                {
                    uniqueLetters.Remove(s[left]);
                    left++;
                }

                left++;
            }

            right++;
        }

        return maxLen;
    }
}