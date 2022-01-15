
public class Solution
{
    public int Search(int[] nums, int tar)
    {
        int lo = 0, hi = nums.Length - 1;
        while (lo <= hi)
        {
            int mid = (lo + hi) >> 1;
            if (nums[mid] == tar) return mid;
            if (nums[lo] <= nums[mid])
            {
                if (tar >= nums[lo] && tar <= nums[mid]) hi = mid - 1;
                else lo = mid + 1;
            }
            else
            {
                if (tar >= nums[mid] && tar <= nums[hi]) lo = mid + 1;
                else hi = mid - 1;
            }
        }
        return -1;
    }
}