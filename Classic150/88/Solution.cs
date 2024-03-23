namespace Classic150._88;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int p1 = m - 1, p2 = n - 1, tail = m + n - 1;

        while (p1 >= 0 || p2 >= 0)
        {
            int current;
            if (p1 == -1)
            {
                current = nums2[p2--];
            }
            else if (p2 == -1)
            {
                current = nums1[p1--];
            }
            else if (nums1[p1] > nums2[p2])
            {
                current = nums1[p1--];
            }
            else
            {
                current = nums2[p2--];
            }

            nums1[tail--] = current;
        }
    }
}