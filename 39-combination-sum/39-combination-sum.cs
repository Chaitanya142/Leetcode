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
                //var newList = new List<int>(tempList);
                tempList.Add(nums[i]);
                backtrack(list, tempList, nums, remain - nums[i], i); // not i + 1 because we can reuse same elements
                tempList.RemoveAt(tempList.Count() - 1);
            }
        }
    }
}
