public class Solution {
    public string MinWindow(string s, string t) {
        if(s.Length < t.Length) return "";
        var sMap = new Dictionary<char, int>();
        var tMap = new Dictionary<char, int>();
     
        foreach(char item in t){
            if(tMap.ContainsKey(item)){
                tMap[item] += 1;
            }else{
                tMap.Add(item, 1);
            }
        }
        int need = tMap.Count; int have = 0;
        int l = 0;
        int[] res = { -1, -1 };
        int minLength = int.MaxValue;

        for(int r = 0; r < s.Length ; r++)
        {
            if(sMap.ContainsKey(s[r])){
                sMap[s[r]]++;
            }else{
                sMap.Add(s[r], 1);
            }
            if(tMap.ContainsKey(s[r]) && tMap[s[r]] == sMap[s[r]]){
                have++;
            }
            while(need == have){
                if ((r - l + 1) < minLength) {
                    minLength = r - l + 1;
                    res[0] = l;
                    res[1] = r;
                }
                sMap[s[l]]--;
                if(tMap.ContainsKey(s[l]) && sMap[s[l]] < tMap[s[l]]){
                    have--;
                }
                l++;
            }

        }
        return minLength == int.MaxValue ? "" : s.Substring(res[0], minLength);
    }
}
