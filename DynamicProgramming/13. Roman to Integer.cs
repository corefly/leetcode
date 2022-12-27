namespace DynamicProgramming;

public class RomanToInteger
{
    private static IDictionary<char, int> _dictionaryNumbers = new Dictionary<char, int>
    {
        {'I', 1},
        {'V', 5},
        {'X', 10},
        {'L', 50},
        {'C', 100},
        {'D', 500},
        {'M', 1000},
    };

    public int RomanToInt(string s)
    {
        var sum = 0;

        for (var i = s.Length - 1; i >= 0; i--)
        {
            if (_dictionaryNumbers[s[i]] >= _dictionaryNumbers[s[i + 1]])
            {
                sum += _dictionaryNumbers[s[i]];
            }
            else
            {
                sum -= _dictionaryNumbers[s[i]];
            }
        }

        return sum;
    }
}
