public class Solution {
    public int MaxProduct(int[] nums) {
        if(nums.Length == 1) return nums[0];
        var max = nums[0];
        var min = nums [0];
        var result = 0;
        for(var i = 1; i < nums.Length; i++)
        {
            if(nums[i] < 0)
            {
                var temp = max;
                max = min;
                min = temp;
            }
            max = Math.Max(nums[i], nums[i] * max);
            min = Math.Min(nums[i], nums[i] * min);
            result = Math.Max(result, max);
        }
        return result;
    }
}
