using Xunit;

namespace DynamicProgramming;

public class LongestSubstringWithoutRepeatingCharacters
{
    public int LengthOfLongestSubstring(string s) {
        
        const int numberOfChars = 256;

        var result = 0;
        var i = 0;
        var lastIndex = new int[numberOfChars];

        Array.Fill(lastIndex, -1);

        for (var j = 0; j < s.Length; j++)
        {
            i = Math.Max(i, lastIndex[s[j]] + 1);
            result = Math.Max(result, j - i + 1);
            lastIndex[s[j]] = j;
        }

        return result;
    }


    
    [Theory]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void Test(string str, int length)
    {
        var actual = LengthOfLongestSubstring(str);

        Assert.True(actual == length);
    }
}
