namespace Corefly.LeetCode.DynamicProgramming.Tests;

public class SubsequenceTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(Subsequence.IsSubsequence("abc", "ahbgdc"));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(Subsequence.IsSubsequence("axc", "ahbgdc"));
    }
}
