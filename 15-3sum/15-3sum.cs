
public class Solution
{
    public IList<IList<int>> ThreeSum(int[] nums)
    {
        IList<IList<int>> lst = new List<IList<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
            {
                continue;
            }

            int l = i + 1;
            int r = nums.Length - 1;
            while (l < r)
            {
                int threeSum = nums[l] + nums[r] + nums[i];
                if (threeSum > 0)
                    r -= 1;
                else if (threeSum < 0)
                    l += 1;
                else
                {
                    lst.Add(new List<int> { nums[l], nums[r], nums[i] });
                    l += 1;
                    while (nums[l] == nums[l - 1] && l < r)
                        l += 1;
                }
            }
        }
        return lst;
    }

}