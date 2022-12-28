using System.Text;

namespace DynamicProgramming;

public class ZigzagConversion
{
    public string Convert(string s, int numRows)
    {
        if (s == string.Empty || numRows <= 0)
        {
            return string.Empty;
        }

        if (numRows == 1)
        {
            return s;
        }

        var sb = new StringBuilder();
        var step = 2 * numRows - 2;

        for (var i = 0; i < numRows; i++)
        {
            for (var j = i; j < s.Length; j += step)
            {
                sb.Append(s[j]);

                if (i != 0 && i != numRows - 1 && (j + step - 2 * i) < s.Length)
                {
                    sb.Append(s[j + step - 2 * i]);
                }
            }
        }

        return sb.ToString();
    }
}
