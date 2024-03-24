namespace Interview150._274;

public class Solution
{
    public int HIndex(int[] citations)
    {
        int n = citations.Length, total = 0;
        int[] count = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (citations[i] >= n)
            {
                count[n]++;
            }
            else
            {
                count[citations[i]]++;
            }
        }

        for (int i = n; i >= 0; i--)
        {
            total += count[i];
            if (total >= i)
            {
                return i;
            }
        }

        return 0;
    }
}