public class Solution {
    private Dictionary<int, int> cache = new Dictionary<int, int>();
    public int CoinChange(int[] coins, int amount) {
        var min = DFS(coins, amount);
        return min >= int.MaxValue ? -1 : min;
    }
    private int DFS(int[] coins, int amount)
    {
        if(amount == 0) return 0;
        if(cache.ContainsKey(amount)) return cache[amount];
        var res = int.MaxValue;
        foreach(var coin in coins)
        {
            if(amount - coin >= 0)
            {
                var result = DFS(coins, amount - coin);
                if(result != int.MaxValue)
                {
                    res = Math.Min(res, 1 + result);
                }
            }
        }
        cache.Add(amount, res);
        return res;
    }
}
