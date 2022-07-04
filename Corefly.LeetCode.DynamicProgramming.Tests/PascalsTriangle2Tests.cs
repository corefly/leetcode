using Corefly.LeetCode.DynamicProgramming.Tests.Comparers;

namespace Corefly.LeetCode.DynamicProgramming.Tests;

public class PascalsTriangle2Tests
{
    [Fact]
    public void Test1()
    {
        var expected = new List<int> { 1, 3, 3, 1 };
        var actual = PascalsTriangle2.GetRow(3);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }

    [Fact]
    public void Test2()
    {
        var expected = new List<int> { 1 };
        var actual = PascalsTriangle2.GetRow(0);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }

    [Fact]
    public void Test3()
    {
        var expected = new List<int> { 1, 1 };
        var actual = PascalsTriangle2.GetRow(1);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }
}
