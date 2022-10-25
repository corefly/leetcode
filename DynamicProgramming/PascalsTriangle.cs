using DynamicProgramming.TestHelpers;
using Xunit;

namespace DynamicProgramming;

public class PascalsTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var pascalsTriangle = new List<IList<int>>(numRows);
        var prevRow = default(IList<int>);

        while (numRows > 0)
        {
            prevRow = GenerateNextRow(prevRow);
            pascalsTriangle.Add(prevRow);
            numRows--;
        }

        return pascalsTriangle;
    }

    private static IList<int> GenerateNextRow(IList<int>? prevRow)
    {
        prevRow ??= new List<int>();

        var nextRow = new List<int>();
        nextRow.Add(1);

        if (prevRow.Count > 0)
        {
            for (var i = 0; i < prevRow.Count - 1; i++)
            {
                var value = prevRow[i] + prevRow[i + 1];
                nextRow.Add(value);
            }
            nextRow.Add(1);
        }
        return nextRow;
    }

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
        var actual = Generate(5);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var expected = new List<List<int>> { new() { 1 } };
        var actual = Generate(1);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }
}
