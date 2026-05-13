public class Solution {
    public int LongestCommonSubsequence(string text1, string text2) {
        if(text2.Length < text1.Length)
        {
            var temp = text2;
            text2 = text1;
            text1 = temp;
        }
        var dp = new int[text2.Length + 1];
        for(var i = text1.Length - 1; i >= 0; i--)
        {
            var prev = 0;
            for(var j = text2.Length - 1; j >= 0; j--)
            {
                var temp = dp[j];
                if(text2[j] == text1[i])
                {
                    dp[j] = 1 + prev;
                }else{
                    dp[j] = Math.Max(dp[j], dp[j + 1]);
                }
                prev = temp;
            }
        }
        return dp[0];
    }
}
  