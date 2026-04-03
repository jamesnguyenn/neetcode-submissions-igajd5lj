public class Solution {
    public bool IsAnagram(string s, string t) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        foreach(var item in s)
        {
           if(!dict.ContainsKey(item))
           {
             dict.Add(item, 1);
           }else{
             dict[item] += 1;
           }
         
        }
        foreach(var item in t)
        {
            if(!dict.ContainsKey(item))
            {
                dict.Add(item, 1);
            }else{
                dict[item] -= 1;
            }
        }
        foreach (var item in dict.Values)
        {
            Console.WriteLine(item);
        }
        return !dict.Values.Any(x => x>=1);

    }
}
