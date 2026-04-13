public class Solution {
    public string LongestPalindrome(string s) {
       int resIdx = 0,resLength=0;
       var n = s.Length;
       bool[,] dp = new bool[n,n];
       for(var i = n - 1; i >= 0 ; i--)
       {
            for(var j = i; j < n; j++)
            {
                if(s[i] == s[j] && (j - i <= 2 || dp[i+1, j-1]))
                {
                    dp[i,j] = true;
                    if((j-i+1) > resLength)
                    {
                        resIdx = i;
                        resLength = j - i + 1;
                    }
                    
                }
            }
       }

       return s.Substring(resIdx, resLength);
    }
}
