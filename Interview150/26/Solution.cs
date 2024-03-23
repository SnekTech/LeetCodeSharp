namespace Interview150._26;

public class Solution {
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        if (n == 0) return 0;

        int slow = 1, fast = 1;
        while (fast < n)
        {
            if (nums[fast] != nums[fast - 1])
            {
                nums[slow] = nums[fast];
                slow++;
            }

            fast++;
        }

        return slow;
    }
}