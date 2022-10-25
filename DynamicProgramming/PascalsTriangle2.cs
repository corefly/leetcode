using DynamicProgramming.TestHelpers;
using Xunit;

namespace DynamicProgramming;

public class PascalsTriangle2
{
    public static IList<int> GetRow(int rowIndex)
    {
        var pascalsTriangle = PascalsTriangle.Generate(rowIndex + 1);

        return pascalsTriangle[rowIndex];
    }

    [Fact]
    public void Test1()
    {
        var expected = new List<int> { 1, 3, 3, 1 };
        var actual = GetRow(3);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }

    [Fact]
    public void Test2()
    {
        var expected = new List<int> { 1 };
        var actual = GetRow(0);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }

    [Fact]
    public void Test3()
    {
        var expected = new List<int> { 1, 1 };
        var actual = GetRow(1);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }
}
