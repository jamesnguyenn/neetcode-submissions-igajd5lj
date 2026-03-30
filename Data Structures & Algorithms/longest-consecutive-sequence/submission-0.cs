public class Solution {
    public int LongestConsecutive(int[] nums) {
       HashSet<int> set = new HashSet<int>(nums);
       var longest = 0;
       foreach (var item in set)
        {
            if(!set.Contains(item - 1))
            {
                var length = 1;
                while(set.Contains(item + length))
                {
                    length++;
                }
                longest = Math.Max(longest, length);

            }
        }
        return longest;
    }
}
