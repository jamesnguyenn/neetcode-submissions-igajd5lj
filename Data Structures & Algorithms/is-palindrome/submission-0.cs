public class Solution {
    public bool IsPalindrome(string s) {
        var left = 0;
        var right = s.Length - 1;
       while(left < right){
            while(left < right && !IsAlphaNum(s[left]))
            {
                left++;
            }
            while(right > left && !IsAlphaNum(s[right]) )
            {
                right--;
            }
            if(char.ToLower(s[left]) != char.ToLower(s[right]))
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }
    public bool IsAlphaNum(char c)
    {
        return (c >= 'A' && c <= 'Z' ||
                c >= 'a' && c <= 'z' ||
                c >= '0' && c <= '9');
    }
}
