namespace Corefly.LeetCode.DynamicProgramming.Tests;

public class DivisorGameTests
{
    [Fact]
    public void Test1()
    {
        Assert.True(DivisorGame.SolveDivisorGame(2));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(DivisorGame.SolveDivisorGame(3));
    }
}
