using Xunit;

namespace DynamicProgramming;

public class Subsequence
{
    public static bool IsSubsequence(string s, string t)
    {
        if (string.IsNullOrEmpty(s))
        {
            return true;
        }

        var i = 0;

        return t.Any(ch => s[i] == ch && ++i == s.Length);
    }

    [Fact]
    public void Test1()
    {
        Assert.True(IsSubsequence("abc", "ahbgdc"));
    }

    [Fact]
    public void Test2()
    {
        Assert.False(IsSubsequence("axc", "ahbgdc"));
    }
}
