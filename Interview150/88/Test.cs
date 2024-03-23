using FluentAssertions;
using NUnit.Framework;

namespace Interview150._88;

public class Test
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        int[] nums1 = [0], nums2 = [1];
        const int m = 0, n = 1;
        solution.Merge(nums1, m, nums2, n);

        nums1.Should().Equal([1]);
    }
}