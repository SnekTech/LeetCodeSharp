using System.Text;

namespace Interview150._125;

public class Solution
{
    public bool IsPalindrome(string s)
    {
        var s2Builder = new StringBuilder();
        foreach (var c in s.Where(char.IsLetterOrDigit))
        {
            s2Builder.Append(c);
        }

        var s2 = s2Builder.ToString().ToLower();
        int left = 0, right = s2.Length - 1;

        while (left < right)
        {
            if (s2[left] != s2[right])
            {
                return false;
            }

            left++;
            right--;
        }

        return true;
    }
}