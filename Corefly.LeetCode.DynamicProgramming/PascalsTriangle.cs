namespace Corefly.LeetCode.DynamicProgramming;

public class PascalsTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var pascalsTriangle = new List<IList<int>>(numRows);
        var prevRow = default(IList<int>);

        while (numRows > 0)
        {
            prevRow = GenerateNextRow(prevRow);
            pascalsTriangle.Add(prevRow);
            numRows--;
        }

        return pascalsTriangle;
    }

    private static IList<int> GenerateNextRow(IList<int>? prevRow)
    {
        prevRow ??= new List<int>();

        var nextRow = new List<int>();
        nextRow.Add(1);

        if (prevRow.Count > 0)
        {
            for (var i = 0; i < prevRow.Count - 1; i++)
            {
                var value = prevRow[i] + prevRow[i + 1];
                nextRow.Add(value);
            }
            nextRow.Add(1);
        }
        return nextRow;
    }
}
