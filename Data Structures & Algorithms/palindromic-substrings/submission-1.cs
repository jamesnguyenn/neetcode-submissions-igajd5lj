public class Solution {
    public int CountSubstrings(string s) {
        var count = 0;
        for(var i = 0; i < s.Length; i++)
        {
                count += Expand(s, i, i); // odd
                count += Expand(s, i,  i + 1); //even
        }
        return count;
    }

    public int Expand(string s, int i, int j)
    {
        var count = 0;
        var l = i;
        var r = j;

        while( l >=0 && r < s.Length && s[l] == s[r])
        {
            l--;
            r++;
            count++;
        }
        return count;
    }
}
