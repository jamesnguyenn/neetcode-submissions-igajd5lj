public class Solution {
    public int Rob(int[] nums) {
       var memo = new int[nums.Length];
       for(var i = 0; i < nums.Length; i++)
       {
            memo[i] = -1;
       }
       return DFS(nums, 0, memo);
    }
    public int DFS(int[] nums, int i, int[] memo)
    {
        if(i >= nums.Length) return 0;
        if(memo[i] != -1) return memo[i];
        var step1 = nums[i] + DFS(nums, i + 2,memo);
        var step2 = DFS(nums,i + 1,memo);
        memo[i] = Math.Max(step1 , step2);
        return memo[i];
    }
}
