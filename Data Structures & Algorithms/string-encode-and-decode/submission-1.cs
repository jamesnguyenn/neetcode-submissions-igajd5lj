public class Solution {

    public string Encode(IList<string> strs) {
        string result = "";
        foreach(var item in strs)
        {
            result +=item.Length;
            result += "#";
            result += item;
        }
        return result;
    }

    public List<string> Decode(string s) {
       List<string> result = new List<string>();
       var i = 0;
       while(i < s.Length)
       {
             var j = i;
             while(s[j] != '#') j++;
             int length = int.Parse(s.Substring(i, j - i));
             result.Add(s.Substring(j + 1, length));
             i = j+ 1 + length;
       }
       return result;
   }
}
