using System.Text;

namespace DynamicProgramming;

public class LongestCommonPrefixSolution
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return string.Empty;
        }

        var sb = new StringBuilder();
        var minLength = strs.Min(x => x.Length);

        for (var i = 0; i < minLength; i++)
        {
            var currentChar = strs[0][i];

            if (strs.Any(str => str[i] != currentChar))
            {
                return sb.ToString();
            }

            sb.Append(currentChar);
        }

        return sb.ToString();
    }
}
