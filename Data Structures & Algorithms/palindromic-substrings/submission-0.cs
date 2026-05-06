public class Solution {
    public int CountSubstrings(string s) {
        var count = 0;
        for(var i = 0; i < s.Length; i++)
        {
            for(var j = i; j < s.Length; j++)
            {
                var subString = s.Substring(i, j - i + 1);
                if(IsPalindromic(subString))
                {
                    count++;
                }
            }
        }
        return count;
    }

    public bool IsPalindromic(string s)
    {
        var l = 0;
        var r = s.Length - 1;

        while(l <= r)
        {
            if(s[l] != s[r]) return false;
            l++;
            r--;
        }
        return true;
    }
}
