namespace DynamicProgramming;
public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums)
    {
        var count = 0;
        for (var i = 0; i < nums.Length; i++)
        {
            if (i < nums.Length - 1 && nums[i] == nums[i + 1])
            {
                continue;
            }

            nums[count] = nums[i];
            count++;
        }
        return count;
    }
}
