using FluentAssertions;
using NUnit.Framework;

namespace Interview150.BinarySearch._35;

[TestFixture]
public class Test
{
    private Solution _solution = new();
    
    [Test]
    public void Case1()
    {
        int[] nums = [1, 3, 5, 6];
        const int target = 2;
        var position = _solution.SearchInsert(nums, target);

        position.Should().Be(1);
    }
}