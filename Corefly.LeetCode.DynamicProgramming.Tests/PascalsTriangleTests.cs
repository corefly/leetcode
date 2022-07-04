using Corefly.LeetCode.DynamicProgramming.Tests.Comparers;

namespace Corefly.LeetCode.DynamicProgramming.Tests;

public class PascalsTriangleTests
{
    [Fact]
    public void Test1()
    {
        var expected = new List<List<int>>
        {
            new() { 1 },
            new() { 1,1 },
            new() { 1,2,1 },
            new() { 1,3,3,1 },
            new() { 1,4,6,4,1 }
        };
        var actual = PascalsTriangle.Generate(5);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var expected = new List<List<int>> { new() { 1 } }; 
        var actual = PascalsTriangle.Generate(1);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }
}
