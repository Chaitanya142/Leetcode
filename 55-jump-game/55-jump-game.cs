public class Solution
{
    public bool CanJump(int[] nums)
    {   
        int dis = 0;
        for (int i = 0; i <= dis; i++) {
            dis = Math.Max(dis, i + nums[i]);
            if (dis >= nums.Length-1) {
                return true;
            }
        }
        return false;
    }
}
