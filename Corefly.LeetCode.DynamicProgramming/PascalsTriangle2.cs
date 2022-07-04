namespace Corefly.LeetCode.DynamicProgramming;

public class PascalsTriangle2
{
    public static IList<int> GetRow(int rowIndex)
    {
        var pascalsTriangle = PascalsTriangle.Generate(rowIndex + 1);

        return pascalsTriangle[rowIndex];
    }
}
