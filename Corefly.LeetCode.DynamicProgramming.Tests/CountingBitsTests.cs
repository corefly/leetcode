using Corefly.LeetCode.DynamicProgramming.Tests.Comparers;

namespace Corefly.LeetCode.DynamicProgramming.Tests;

public class CountingBitsTests
{
    [Fact]
    public void Test1()
    {
        var expected = new[] { 0, 1, 1, 2, 1, 2 };
        var actual = CountingBits.CountBits(5);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }

    [Fact]
    public void Test2()
    {
        var expected = new[] { 0, 1, 1 };
        var actual = CountingBits.CountBits(2);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }
}