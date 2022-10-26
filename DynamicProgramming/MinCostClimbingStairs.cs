using Xunit;

namespace DynamicProgramming;

public class MinCostClimbingStairs
{
    public static int GetMinCostClimbingStairs(int[] cost)
    {
        for (var i = cost.Length - 3; i >= 0; i--)
        {
            cost[i] += Math.Min(cost[i + 1], cost[i + 2]);
        }

        return Math.Min(cost[0], cost[1]);
    }

    [Fact]
    public void Test1()
    {
        var expected = 15;
        var actual = GetMinCostClimbingStairs(new[] { 10, 15, 20 });

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var expected = 6;
        var actual = GetMinCostClimbingStairs(new[] { 1, 100, 1, 1, 1, 100, 1, 1, 100, 1 });

        Assert.Equal(expected, actual);
    }
}
