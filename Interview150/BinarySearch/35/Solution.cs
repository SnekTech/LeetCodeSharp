namespace Interview150.BinarySearch._35;

public class Solution
{
    public int SearchInsert(int[] nums, int target)
    {
        var n = nums.Length;
        int left = 0, right = n - 1;
        while (left <= right)
        {
            var mid = left + (right - left) / 2;
            var midVal = nums[mid];
            if (target == midVal)
                return mid;
            
            if (target < midVal)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        
        return left;
    }
}