namespace Interview150._169;

public class Solution {
    public int MajorityElement(int[] nums)
    {
        var numCounts = CountNums(nums);

        int candidate = nums[0], candidateCount = 1;
        foreach (var (num, count) in numCounts)
        {
            if (count > candidateCount)
            {
                candidate = num;
                candidateCount = count;
            }
        }

        return candidate;
    }

    private static Dictionary<int, int> CountNums(int[] nums)
    {
        var dict = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num] += 1;
            }
        }

        return dict;
    }
}