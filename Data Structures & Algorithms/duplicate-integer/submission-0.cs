public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(var i = 0; i < nums.Length; i++)
        {
            if(dict.ContainsKey(nums[i]))
            {
                return true;
            }else{
                dict.Add(nums[i], 1);
            }
        }
        return false;
    }
}