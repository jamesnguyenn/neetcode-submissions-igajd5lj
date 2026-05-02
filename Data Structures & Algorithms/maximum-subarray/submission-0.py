class Solution:
    def maxSubArray(self, nums: List[int]) -> int:
        curr = maxSum = nums[0]
        for n in nums[1:]:
            curr = max(n , curr + n )
            maxSum = max(maxSum, curr)
        
        return maxSum