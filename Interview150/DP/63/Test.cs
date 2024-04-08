using FluentAssertions;
using NUnit.Framework;

namespace Interview150.DP._63;

[TestFixture]
public class Test
{
    [Test]
    public void Case1()
    {
        int[][] obstacleGrid = [[1, 0]];
        var solution = new Solution();

        solution.UniquePathsWithObstacles(obstacleGrid)
            .Should().Be(0);
    }
}