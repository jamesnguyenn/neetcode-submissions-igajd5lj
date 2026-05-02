class Solution:
    def canJump(self, nums: List[int]) -> bool:
        length = len(nums)
        maxReach = 0
        for i in range(length):
            if i > maxReach : return False
            maxReach = max(maxReach, i + nums[i])
        return True
