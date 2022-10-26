namespace DynamicProgramming;

public class MaximumSubarray
{
    public int MaxSubArray(int[] nums) {
        var n = nums.Length;
        var dp = new int[n];
        dp[0] = nums[0];
        var max = dp[0];
        
        for(var i = 1; i < n; i++){
            dp[i] = nums[i] + (dp[i - 1] > 0 ? dp[i - 1] : 0);
            max = Math.Max(max, dp[i]);
        }
        
        return max;
    }
}
