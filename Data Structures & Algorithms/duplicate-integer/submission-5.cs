public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> set = new HashSet<int>(nums.Length);

        for(var i = 0; i < nums.Length; i++)
        {
            if(!set.Add(nums[i])) return true;
        }
        return false;
    }
}