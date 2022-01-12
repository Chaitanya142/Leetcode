public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i=0;i<nums.Length;i++){
            for(int j=i+1;j<nums.Length;j++){
                if(nums[i]+nums[j]==target)
                {
                    int[] soltn=new int[2];
                    soltn[0]=i;
                    soltn[1]=j;
                    return soltn;
                }
            }
        }
        return new int[2];
    }
}
