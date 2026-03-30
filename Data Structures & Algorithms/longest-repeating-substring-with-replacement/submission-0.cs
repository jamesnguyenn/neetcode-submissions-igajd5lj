public class Solution {
    public int CharacterReplacement(string s, int k) {
        int l = 0;
        int max = 0;
        Dictionary<char, int> dict = new Dictionary<char,int>(26){};
        for(var r = 0; r < s.Length; r++)
        {
            if(!dict.ContainsKey(s[r])){
                dict.Add(s[r], 1);
            }else{
                dict[s[r]]+=1;
            }
            var length  = r - l + 1;

            if((length - dict.Values.Max()) <= k)
            {
               max = Math.Max(max, length);
            }else{
                dict[s[l]] -=1;
                l++;
            }

        }
        return max;
    }
}
