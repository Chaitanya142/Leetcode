public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int max = int.MinValue, sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            max = Math.Max(sum, max);
            sum = sum < 0 ? 0 : sum;
        }

        return max;
    
    }
}