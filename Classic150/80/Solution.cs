namespace Classic150._80;

public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        int n = nums.Length;
        if (n <= 2)
            return n;

        int slow = 2, fast = 2;
        while (fast < n)
        {
            if (nums[fast] != nums[slow - 2])
            {
                nums[slow] = nums[fast];
                slow++;
            }

            fast++;
        }

        return slow;
    }
}