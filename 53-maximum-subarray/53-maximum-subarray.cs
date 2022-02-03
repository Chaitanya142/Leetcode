//DP
public class Solution {
 public int MaxSubArray(int[] nums)
    {
        int[] storage = new int[nums.Length];
        int max = nums[0];
        storage[0] = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            storage[i] = Math.Max(storage[i - 1] + nums[i], nums[i]);
            if (storage[i] > max)
            {
                max = storage[i];
            }
        }
        return max;
    }
}


