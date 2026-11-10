public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        var list = new int[26];
        for(var i = 0; i < s.Length; i++)
        {
            list[s[i] - 'a'] +=1;
            list[t[i] - 'a'] -=1;
        }
        for(var i = 0; i < list.Length; i++)
        {
            if(list[i] != 0) return false;
        }
        return true;
    }
}
