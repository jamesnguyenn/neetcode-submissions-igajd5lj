public class Solution {
    public int MissingNumber(int[] nums) {
       var expected = (nums.Length * (nums.Length + 1)) / 2;
       var sum = 0;
       foreach(var num in nums)
       {
            sum+=num;
       }
       return expected - sum;
    }
}
