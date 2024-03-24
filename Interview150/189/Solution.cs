namespace Interview150._189;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        var rotated = new List<int>(n);
        rotated.AddRange(nums);
        for (int i = 0; i < n; i++)
        {
            rotated[(i + k) % n] = nums[i];
        }

        for (int i = 0; i < n; i++)
        {
            nums[i] = rotated[i];
        }
    }
}