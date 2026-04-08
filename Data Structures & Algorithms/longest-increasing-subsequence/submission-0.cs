public class Solution {
    public int LengthOfLIS(int[] nums) {
        int[] cache = new int[nums.Length];
        for(var i = 0; i < cache.Length; i++) cache[i] = 1;
        for(var i = nums.Length - 1; i >= 0 ; i--)
        {
            for(var j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] < nums[j])
                {
                    cache[i] = Math.Max(cache[i], 1 + cache[j]);
                }
            }
        }
        return cache.Max();
    }
}
