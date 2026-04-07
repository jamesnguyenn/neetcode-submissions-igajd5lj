public class Solution {
    public int MaxProfit(int[] prices) {
        var l = 0;
        var max = 0;
        for(var r = 1; r < prices.Length; r++)
        {
            if(prices[l] < prices[r])
            {
                max = Math.Max(max, prices[r] - prices[l]);
            }else{
                l = r;
            }
        }
        return max;
    }
}
