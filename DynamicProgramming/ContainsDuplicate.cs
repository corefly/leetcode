namespace DynamicProgramming;

public class ContainsDuplicate
{
    public static bool IsContainsDuplicate(int[] nums)
    {
        var set = new HashSet<int>(nums.Length);

        foreach (var num in nums)
        {
            var isAddedNum = set.Add(num);

            if (!isAddedNum)
            {
                return true;
            }
        }

        return false;
    }
}

