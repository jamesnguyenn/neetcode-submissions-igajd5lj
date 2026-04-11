public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1) return nums[0];
       return Math.Max(
        DFS(nums, 0, nums.Length - 2),
        DFS(nums, 1, nums.Length - 1)
       );
    }
    private int DFS(int[] nums, int start, int end)
    {
       var rob1 = 0;
       var rob2 = 0;
       for(var i = start; i <= end; i++)
       {
            var temp = Math.Max(nums[i] + rob2, rob1);
            rob2 = rob1;
            rob1 = temp;
       }
       return rob1;
    }
}
 