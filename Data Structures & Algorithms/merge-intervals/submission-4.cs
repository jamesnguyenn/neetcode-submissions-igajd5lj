public class Solution {
    public int[][] Merge(int[][] intervals) {
        var result = new List<int[]>();
        Array.Sort(intervals, (a,b)=>a[0].CompareTo(b[0]));
        result.Add(intervals[0]);

        foreach(var item in intervals)
        {
            var start = item[0];
            var end = item[1];
            var lastEnd =  result[result.Count  - 1][1];
            if(start <= lastEnd)
            {
                result[result.Count - 1][1] = Math.Max(lastEnd, end);
            }else{
                result.Add(item);
            }
        }


        return result.ToArray();
    }
}
