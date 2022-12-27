namespace DynamicProgramming;

public class ValidParentheses
{
    public bool IsValid(string s) {
        var dict = new Dictionary<char, char>
        {
            {'(', ')'},
            {'{', '}'},
            {'[', ']'}
        };
        var stack = new Stack<char>(s.Length);

        foreach (var ch in s)
        {
            if (stack.TryPeek(out var peek))
            {
                if (dict.ContainsKey(peek) && ch == dict[peek])
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(ch);
                }
            }
            else
            {
                stack.Push(ch);
            }
        }

        return stack.Count == 0;
    }
}
