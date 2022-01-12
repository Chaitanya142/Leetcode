class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        sum_pairs = dict()
        
        for idx in range(len(nums)):
            if sum_pairs.get(nums[idx]) is not None:
                return [sum_pairs.get(nums[idx]), idx]
            else:
                sum_pairs[target - nums[idx]] = idx
        
        return list()