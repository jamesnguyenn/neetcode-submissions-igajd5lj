public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        // [a,b,c,d]
        // Soluton 1
        // [1,  a, ab,abc]
        // [bcd,cd,d, 1]
        // Solution 2
        // [1,a,ab,abc]
        // [bcd,cd,d,1]
        // [bcd, acd, abd, abc]
        var result = new List<int>(nums.Length);
       for (int i = 0; i < nums.Length; i++){
           result.Add(1);
       }

        for(var i = 1; i < nums.Length; i++)
        {
            result[i] = result[i - 1] * nums[i - 1];
        }

        var postfix = 1;
        for(var i = nums.Length - 1; i >= 0; i--)
        {
           result[i] *= postfix;
           postfix *= nums[i];
        }

        return result.ToArray();
    }
}
