using Xunit;

namespace DynamicProgramming;

public class ClimbingStairs
{
    public static int ClimbStairs(int n)
    {
        if (n == 1)
        {
            return 1;
        }

        var n1 = 1;
        var n2 = 2;
        for (var i = 3; i < n + 1; i++)
        {
            var t = n1;
            n1 = n2;
            n2 = t + n2;
        }

        return n2;
    }

    [Fact]
    public void Test1()
    {
        var expected = 2;
        var actual = ClimbStairs(2);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Test2()
    {
        var expected = 3;
        var actual = ClimbStairs(3);

        Assert.Equal(expected, actual);
    }
}
