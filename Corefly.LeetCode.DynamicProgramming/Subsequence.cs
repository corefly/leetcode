namespace Corefly.LeetCode.DynamicProgramming;

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
}
