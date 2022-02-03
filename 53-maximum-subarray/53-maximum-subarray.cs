public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int n = nums.Length;
        int max = int.MinValue, sum = 0;

        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
            max = Math.Max(sum, max);

            if (sum < 0) sum = 0;
        }

        return max;
    
    }
}