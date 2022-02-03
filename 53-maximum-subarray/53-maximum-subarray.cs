public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int max = int.MinValue, sum = 0;

        foreach(var no in nums)
        {
            sum += no;
            max = Math.Max(sum, max);
            sum = sum < 0 ? 0 : sum;
        }

        return max;
    
    }
}