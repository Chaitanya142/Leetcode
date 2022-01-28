public class Solution {
    public IList<IList<int>> CombinationSum(int[] nums, int target)
    {
        IList<IList<int>> list = new List<IList<int>>();
        Array.Sort(nums);
        backtrack(list, new List<int>(), nums, target, 0);
        return list;
    }

    private void backtrack(IList<IList<int>> list, List<int> tempList, int[] nums, int remain, int start)
    {
        if (remain < 0) return;
        else if (remain == 0)
        {
            list.Add(new List<int>(tempList));
        }
        else
        {
            for (int i = start; i < nums.Length; i++)
            {
                var newList = new List<int>(tempList);
                newList.Add(nums[i]);
                backtrack(list, newList, nums, remain - nums[i], i); // not i + 1 because we can reuse same elements
                newList.Remove(newList.Count() - 1);
            }
        }
    }
}