using DynamicProgramming.TestHelpers;
using Xunit;

namespace DynamicProgramming;

public class CountingBits
{
    public static int[] CountBits(int n)
    {
        var bits = new int[n + 1];
        var offset = 1;

        Array.Fill(bits, 0);

        for (var i = 1; i < bits.Length; i++)
        {
            if (offset * 2 == i)
            {
                offset = i;
            }

            bits[i] = 1 + bits[i - offset];
        }

        return bits;
    }

    [Fact]
    public void Test1()
    {
        var expected = new[] { 0, 1, 1, 2, 1, 2 };
        var actual = CountBits(5);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }

    [Fact]
    public void Test2()
    {
        var expected = new[] { 0, 1, 1 };
        var actual = CountBits(2);

        Assert.Equal(expected, actual, new CollectionEquivalenceComparer<int>());
    }
}
