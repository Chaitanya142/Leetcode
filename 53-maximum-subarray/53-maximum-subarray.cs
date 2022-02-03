//Kanade
public class Solution {
    public int MaxSubArray(int[] nums) {
        
        int max = int.MinValue, sum = 0;

        foreach(var no in nums)
        {
            sum += no;
            max = Math.Max(sum, max);
            if(sum<0)sum=0;
        }

        return max;
    
    }
}