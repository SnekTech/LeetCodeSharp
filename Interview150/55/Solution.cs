namespace Interview150._55;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int n = nums.Length;
        int right = 0;
        for (int i = 0; i < n; i++)
        {
            if (right < i) return false;
            right = Math.Max(right, i + nums[i]);
        }

        return true;
    }
}