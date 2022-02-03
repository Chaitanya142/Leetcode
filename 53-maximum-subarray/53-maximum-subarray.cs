//Divide and concure
public class Solution {

      public int MaxSubArray(int[] nums)
    {

        return helper(nums, 0, nums.Length - 1);
    }

    public int helper(int[] nums, int i, int j)
    {

        if (i == j)
        {
            return nums[i];
        }

        int mid = (i + j) / 2;
        int sum = 0, leftMax = int.MinValue;

        for (int l = mid; l >= i; l--)
        {
            sum += nums[l];
            if (sum > leftMax)
            {
                leftMax = sum;
            }
        }

        int rightMax = int.MinValue;
        sum = 0;    // reset sum to 0
        for (int l = mid + 1; l <= j; l++)
        {
            sum += nums[l];
            if (sum > rightMax)
            {
                rightMax = sum;
            }
        }

        int maxLeftRight = Math.Max(helper(nums, i, mid),
                                     helper(nums, mid + 1, j));
        return Math.Max(maxLeftRight, leftMax + rightMax);

    }
}


