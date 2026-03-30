public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict =  new Dictionary<int, int>();
        var buckets = new List<int>[nums.Length + 1];
        foreach(var item in nums)
        {
            if(dict.ContainsKey(item))
            {
                dict[item] += 1;
            }else{
                dict.Add(item, 1);
            }
        }
        foreach (var item in dict)
        {
            var freq = item.Value;
            if (buckets[freq] == null)
                buckets[freq] = new List<int>();
            buckets[freq].Add(item.Key);
        }

        var result = new List<int>();
        for(var i = buckets.Length - 1; i >= 0; i--)
        {
            if(buckets[i]!=null)
            {
                result.AddRange(buckets[i]);
            }
        }
        return result.Take(k).ToArray();
    }
}
