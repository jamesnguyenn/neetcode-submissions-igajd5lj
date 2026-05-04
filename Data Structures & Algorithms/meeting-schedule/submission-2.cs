/**
 * Definition of Interval:
 * public class Interval {
 *     public int start, end;
 *     public Interval(int start, int end) {
 *         this.start = start;
 *         this.end = end;
 *     }
 * }
 */

public class Solution {
    public bool CanAttendMeetings(List<Interval> intervals) {
        if(intervals == null || intervals.Count <= 1) return true;
        intervals.Sort((a,b)=>a.start.CompareTo(b.start));
        for(var i = 1; i < intervals.Count; i++)
        {
            var item = intervals[i];
            var prev = intervals[i-1];
            if(item.start < prev.end)
            {
                 return false;
            }
        }
        return true;
    }
}
