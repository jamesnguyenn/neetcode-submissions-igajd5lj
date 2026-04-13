public class Solution {
    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (a, b) => a[1].CompareTo(b[1]));
        var result = 0;
        var prevEnd = intervals[0][1];
        for(var i = 1; i < intervals.Length; i++)
        {
            if(prevEnd > intervals[i][0])
            {
                result++;
            }else{
                prevEnd = intervals[i][1]; 
            }
        }
        return result;
    }
}
