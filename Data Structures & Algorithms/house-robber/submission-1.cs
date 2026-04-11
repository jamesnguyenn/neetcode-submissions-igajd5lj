public class Solution {
    public int Rob(int[] nums) {
        var prev1 = 0;
        var prev2 = 0;

        foreach(var item in nums)
        {
            var temp = prev1;
            prev1 = Math.Max(prev2 + item, prev1);
            prev2 = temp;
        }

        return prev1;
    }
}
