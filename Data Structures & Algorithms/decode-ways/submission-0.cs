public class Solution {
    public int NumDecodings(string s) {
        if(s.Length == 0 || s[0] == '0') return 0;
        int[] dp = new int[s.Length + 1];
        dp[0] = 1;
        dp[1] = 1;
        for(var i = 2; i <= s.Length;i++)
        {
            if(IsValidOneDigit(i-1, s)) dp[i]+=dp[i-1];
            if(IsValidTwoDigit(i-1, i-2, s)) dp[i] += dp[i-2];
        }
        return dp[s.Length];
    }
    public bool IsValidOneDigit(int i, string s)
    {
        if(s[i] == '0') return false;
        return true;
    }
    public bool IsValidTwoDigit(int i , int j, string s)
    {
        var num = (s[j] - '0') * 10 + (s[i] - '0');
        if(10 <= num && num <= 26) return true;
        return false;
    }
}
