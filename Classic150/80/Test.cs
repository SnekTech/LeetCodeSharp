using FluentAssertions;
using NUnit.Framework;

namespace Classic150._80;

public class Test
{
    [Test]
    public void Case1()
    {
        var solution = new Solution();
        int[] nums = [1, 1, 1, 2, 2, 3];
        int[] expected = [1, 1, 2, 2, 3];

        int n = solution.RemoveDuplicates(nums);
        nums[0..n].Should().Equal(expected);
    }
}