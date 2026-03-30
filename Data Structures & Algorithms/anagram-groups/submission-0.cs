public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>();

        foreach(var item in strs)
        {
            var list = new int[26];
            foreach(var c in item)
            {
                list[c - 'a'] +=1;
            }
            string key = string.Join(",", list);
            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(item);
        }
        return dict.Values.ToList();
    }
}
