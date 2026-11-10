public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) return false;
        Dictionary<char, int> dict = new Dictionary<char, int>(){};
        for(var i = 0; i < s.Length; i++)
        {
            if(!dict.ContainsKey(s[i]))
            {
                dict[s[i]] = 0;
            }
            dict[s[i]] += 1;
        }
        for(var i = 0; i < t.Length; i++)
        {
            if(!dict.ContainsKey(t[i]) || dict[t[i]] == 0)
            {
                return false;
            }
            dict[t[i]] -= 1;
        }
        return true;
    }
}
