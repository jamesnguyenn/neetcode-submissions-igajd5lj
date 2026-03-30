public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 0) return 0;
        if(s.Length == 1) return 1;
        var l = 0;
        var max = 0;
        var set = new HashSet<char>();
        for(var r = 0; r < s.Length; r++)
        {

            while(set.Contains(s[r])){
                set.Remove(s[l]);
                l++;
            }
            set.Add(s[r]);
            max = Math.Max(max, r - l + 1);
           
        }
        return max;
    }
}
